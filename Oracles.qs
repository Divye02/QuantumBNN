namespace Quantum.QuantumBNN {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Diagnostics;

    // Flip the target bit of the sum of the bits in the register >= min_N.
    // Uses adders.
    //
    //  register    : The input register
    //  target      : The target qubit
    //  min_N       : The required minimum sum of the bits in the register
    operation FlipIfAtleast(register: Qubit[], target: Qubit, min_N: Int): Unit {
        body (...) {
            let N = Length(register);
            let n_bits = Floor(Log(ToDouble(N))/LogOf2()) + 1;

            using ((running_sum, sum, current_bit) = (Qubit[n_bits + 2], Qubit[n_bits + 2], Qubit[n_bits + 2])) {

                // Add one extra as we want >= not >
                X(current_bit[Length(current_bit) - 1]);
                AdderBE(running_sum, current_bit);
                X(current_bit[Length(current_bit) - 1]);

                // Compute running sum of qubits in the register
                for(i in 0..N - 1) {
                    CNOT(register[i], current_bit[Length(current_bit) - 1]);
                    // ModularAddProductLE(1, 2^(Length(running_sum) - 1) - 1, LittleEndian(current_bit), LittleEndian(running_sum));
                    AdderBE(running_sum, current_bit);
                    CNOT(register[i], current_bit[Length(current_bit) - 1]);
                }

                // Convert the minimum sum required to qubit representation
                let bit_array = Reverse(BoolBitArrayLE(min_N, n_bits+2));
                for(i in 0..Length(bit_array) - 1) {
                    if(bit_array[i]) {
                        X(sum[i]);
                    }
                }

                // Compare bit arrays
                ComparatorBE(running_sum, sum, target);

                //
                // Un-entangle
                //

                for(i in 0..Length(bit_array) - 1) {
                    if(bit_array[i]) {
                        X(sum[i]);
                    }
                }

                X(current_bit[Length(current_bit) - 1]);
                Adjoint AdderBE(running_sum, current_bit);
                X(current_bit[Length(current_bit) - 1]);
                for(i in 0..N - 1) {
                    CNOT(register[i], current_bit[Length(current_bit) - 1]);
                    // Adjoint ModularAddProductLE(1, 2^(Length(running_sum) - 1) - 1, LittleEndian(current_bit), LittleEndian(running_sum));
                    Adjoint AdderBE(running_sum, current_bit);
                    CNOT(register[i], current_bit[Length(current_bit) - 1]);
                }

            }
        }
        adjoint auto;
    }

    //
    // Addition Oracles from Kuba's team (THANKS GUYS!): BE
    //
    operation AdderBE (A : Qubit[], B : Qubit[]) : Unit {
        body (...) {

            let N = Length(A);
            let P = Length(B);
            if (N != P) {
                fail "Eror: improper quantum AdderBE usage";
            }   
            QFT((BigEndian(A)));
            for (i in 0..N-1) {
                for (j in 0..i) {
                    Controlled Rzk([A[N-j-1]], (B[i], ToDouble(i-j+1)));
                }
            }
            Adjoint QFT((BigEndian(A)));
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }   
    
    // Flips when d > dmax: BE
    operation ComparatorBE (d : Qubit[], dmax : Qubit[], target : Qubit) : Unit {
        body(...) {
            let N = Length(d);
            let P = Length(dmax);
            if (N != P) {
                fail "Eror: improper ComparatorBE usage";
            }
            (ControlledOnBitString([false, true], X))([d[0], dmax[0]], target);
            using (dmax_tmp = Qubit()) {
                CNOT(dmax[0], dmax_tmp);
                Adjoint AdderBE(dmax, d);
                (ControlledOnBitString([false, false, true], X))([d[0], dmax_tmp, dmax[0]], target);
                (ControlledOnBitString([true, true, true], X))([d[0], dmax_tmp, dmax[0]], target);
                AdderBE(dmax, d);
                CNOT(dmax[0], dmax_tmp);
            }
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    operation Rzk (q : Qubit, k : Double) : Unit {
        body (...) {
            ApplyDiagonalUnitary([0.0, 2.0*PI()/PowD(2.0, k)], BigEndian([q]));
        }
        adjoint auto;
        controlled auto;
        controlled adjoint auto;
    }

    // Returns the Bool[] representation of a number.
    //
    //  num         : The number
    //  num_bits    : The number of bits in the result array
    function BoolBitArrayLE(num: Int, num_bits: Int): Bool[] {
        mutable curr_num = num;
        mutable bool_arr = new Bool[num_bits];

        if (curr_num == 0) {
            return bool_arr;
        }

        repeat {
            let ind = Floor(Log(ToDouble(curr_num))/LogOf2());
            set bool_arr[ind] = true;
            set curr_num = curr_num - 2^(ind);
        }
        until (curr_num == 0)
        fixup {}

        return bool_arr;
    }

    // Flip the target is the register is all 0s or all 1s.
    //
    //  register    : The input register
    //  target      : The target qubit
    operation FlipIfSame(register: Qubit[], target: Qubit): Unit {
        body (...) {
            Controlled X(register, target);

            ApplyToEachA(X, register);
            Controlled X(register, target);
            ApplyToEachA(X, register);
        }
        adjoint auto;
    }

    // Flip the target is the register1 and register2 each is all 0s or all 1s.
    //
    //  register1   : The first input register
    //  register2   : The second input register
    //  target      : The target qubit
    operation FlipIfSame2(register1: Qubit[], register2: Qubit[], target: Qubit): Unit {
        body (...) {
            Controlled X(register1 + register2, target);
            
            ApplyToEachA(X, register1);
            Controlled X(register1 + register2, target);
            ApplyToEachA(X, register1);

            ApplyToEachA(X, register2);
            Controlled X(register1 + register2, target);
            ApplyToEachA(X, register2);

            ApplyToEachA(X, register1);
            ApplyToEachA(X, register2);
            Controlled X(register1 + register2, target);
            ApplyToEachA(X, register1);
            ApplyToEachA(X, register2);
        }
        adjoint auto;
    }

    
    // Flip the target if weights_i*x_i = 1 is in majority.
    // 0 is treated as -1
    // 1 is treated as 1
    //
    //  weights     : The weight values
    //  xs          : The x values
    //  target      : The target qubit
    operation MajorityProductOnes(weights: Qubit[], xs: Qubit[], target: Qubit): Unit {
        body (...) {
            let N = Length(weights);
            if (N == 1) {
               FlipIfSame([weights[0], xs[0]], target);

            } elif (N <= 3) {
                for (i in 0..N-1) {
                    for (j in i+1..N-1) {
                        FlipIfSame2([weights[i], xs[i]], [weights[j], xs[j]], target);
                    }
                }

            } else {
                using(y = Qubit[N]) {
                    let min_N = (N / 2 + 1);
                    for (i in 0..N-1) {
                        FlipIfSame([weights[i], xs[i]], y[i]);
                    }
                    
                    let optmizedForNumQubits = true;
                    if (optmizedForNumQubits) {
                        FlipIfAtLeastRecursive(y, target, min_N);
                    } else {
                        FlipIfAtleast(y, target, min_N);
                    }

                    //
                    // Un-entangle
                    //

                    for (i in 0..N-1) {
                        FlipIfSame([weights[i], xs[i]], y[i]);
                    }
                }
            }
        }
        adjoint auto;
    }

    // Flip the target bit only if the number of correctly predicted labels has a given accuracy.
    //
    //  weights                 : The weights corresponding to the prediction
    //  accuracy                : The desired accuracy
    //  allLayers               : All the layers in the network
    //  input                   : The input data points
    //  labels                  : The true labels for the input data points
    //  target                  : The target qubit
    operation BNNMarkingOracleWithDesiredAccuracy(weights: Qubit[], accuracy: Double, allLayers: Int[], input: Int[][], labels: Int[], target: Qubit) : Unit {
        body(...) {
            let N = Length(input);

            using(correctly_predicted = Qubit[N]) {

                for(i in 0..N-1) {
                    Forward_IntData(weights, allLayers, input[i], labels[i], correctly_predicted[i]);
                }

                let min_N = Ceiling(ToDouble(N) * accuracy);
        
                // If true  ->  Use recursive logic with no extra qubits required.
                // If false ->  Use adder logic with extra qubits required.
                let optmizedForNumQubits = true;
                if (optmizedForNumQubits) {
                    FlipIfAtLeastRecursive(correctly_predicted, target, min_N);
                } else {
                    FlipIfAtleast(correctly_predicted, target, min_N);
                }

                for(i in 0..N-1) {
                    Adjoint Forward_IntData(weights, allLayers, input[i], labels[i], correctly_predicted[i]);
                }
            }
        }
        adjoint auto;
    }

    // Flip the target bit of the sum of the bits in the register >= min_N.
    // Recursive approach by creating possible boolean arrays.
    //
    //  register    : The input register
    //  target      : The target qubit
    //  min_N       : The required minimum sum of the bits in the register
    operation FlipIfAtLeastRecursive(register: Qubit[], target: Qubit, min_N: Int) : Unit {
        body(...) {
            ControlledOnBitStringWithMinTrue(new Bool[0], register, target, min_N);
        }
        adjoint auto;
    }

    operation ControlledOnBitStringWithMinTrue(bool_array: Bool[], register: Qubit[], target: Qubit, minTrue : Int) : Unit {
        body(...) {
            if (Length(bool_array) == Length(register)) {
                if (minTrue < 1) {
                    (ControlledOnBitString(bool_array, X))(register, target);
                }
            } else {
                ControlledOnBitStringWithMinTrue(bool_array + [true], register, target, minTrue - 1);
                ControlledOnBitStringWithMinTrue(bool_array + [false], register, target, minTrue);
            }
        }
        adjoint auto;
    }


    //
    // Oraces for Grovers Algorithm
    //
    function OracleConverter (markingOracle: ((Qubit[], Qubit) => Unit : Adjoint)) : (Qubit[] => Unit : Adjoint) {
        return OracleConverterImpl(markingOracle, _);
    }

    operation OracleConverterImpl (markingOracle: ((Qubit[], Qubit) => Unit : Adjoint), register: Qubit[]) : Unit {
        body (...) {
            using (target = Qubit()) {
                // Put the target into the |-⟩ state
                X(target);
                H(target);
                
                // Apply the marking oracle; since the target is in the |-⟩ state,
                // flipping the target if the register satisfies the oracle condition will apply a -1 factor to the state
                markingOracle(register, target);
                
                // Put the target back into |0⟩ so we can return it
                H(target);
                X(target);
            }
        }
        adjoint invert;
    }

    operation Oracle_ArbitraryPattern (queryRegister: Qubit[], target: Qubit, pattern: Bool[]) : Unit {
        body (...) {
            (ControlledOnBitString(pattern, X))(queryRegister, target);
        }
        adjoint invert;
    }
}
