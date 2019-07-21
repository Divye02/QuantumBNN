namespace Quantum.QuantumBNN {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Testing;
    open Microsoft.Quantum.Extensions.Diagnostics;

    // 
    // Tests for Utils
    //

    // NOTE: Disabled
    operation GetNumCorrectWeights_Test() : Unit {
        mutable hidden_layers = [2];

        // XNOR
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [1, 0, 0, 1];

        let num_correct_weights = GetNumCorrectWeights(input, labels, hidden_layers, 1.0);

        AssertIntEqual(num_correct_weights, 16, "Error while calculating number of correct weights classically" + ToStringI(num_correct_weights));
    }

    //
    // Tests for GorversSearchAlgorithm
    //

    // NOTE: Disabled
    operation GroversSearch_Test() : Unit {
        using(xs = Qubit[2]) {
            // Find all ones state
            H(xs[0]);
            H(xs[1]);
            GroversSearch(xs, Oracle_AllOnes, 1);
            AssertQubit(One, xs[0]);
            AssertQubit(One, xs[1]);
            ResetAll(xs);
        }

        using(xs = Qubit[2]) {
            // Find all zeros state
            H(xs[0]);
            H(xs[1]);
            GroversSearch(xs, Oracle_AllZeros, 1);
            AssertQubit(Zero, xs[0]);
            AssertQubit(Zero, xs[1]);
            ResetAll(xs);
        }
    }

    operation Oracle_AllOnes (queryRegister: Qubit[], target: Qubit) : Unit {
        body (...) {
            Controlled X(queryRegister, target);
        }
        adjoint invert;
    }

    operation Oracle_AllZeros (queryRegister: Qubit[], target: Qubit) : Unit {
        body (...) {
            ApplyToEachA(X, queryRegister);
            Controlled X(queryRegister, target);
            ApplyToEachA(X, queryRegister);
        }
        adjoint invert;
    }


    //
    // Tests for Oracles
    //

    // NOTE: Disabled
    operation FlipIfAtleast_Test() : Unit {
        for(N in 1..3) {
            for (num_ones in 1..N) {
                using((register, target) = (Qubit[N], Qubit())) {
                    ApplyToEachA(X, register[0..num_ones - 1]);

                    for (min_N in 0..N - 1) {
                        FlipIfAtleast(register, target, min_N);
                        if (min_N > num_ones) {
                            // Not enough ones
                            AssertQubit(Zero, target);
                        } else {
                            // Enough ones
                            AssertQubit(One, target);
                        }
                        Reset(target);
                    }
                    Reset(target);
                    ResetAll(register);
                }
            }
        }
    }

    // NOTE: Disabled
    operation BoolBitArrayLE_Test() : Unit {
        let N = 5;
        for (i in 0..N) {
            let result = BoolBitArrayLE(i, N+1);
            mutable sum = 0;
            for (j in 0..N) {
                if (result[j]) {
                    set sum = sum + 2^j;
                }
            }
            AssertBoolEqual(sum == i, true, "Fail");
        }
    }

    // NOTE: Disabled
    operation FlipIfSame_Test() : Unit {
        let N = 3;

        using((register, target) = (Qubit[N], Qubit())) {
            // All same
            FlipIfSame(register, target);
            AssertQubit(One, target);
            Reset(target);

            // Not same
            X(register[0]);
            FlipIfSame(register, target);
            AssertQubit(Zero, target);
            Reset(target);
            
            // Not same
            X(register[1]);
            FlipIfSame(register, target);
            AssertQubit(Zero, target);
            Reset(target);
            
            // All same
            X(register[2]);
            FlipIfSame(register, target);
            AssertQubit(One, target);
            Reset(target);

            ResetAll(register);
        }
    }

    // NOTE: Disabled
    operation FlipIfSame2_Test() : Unit {
        let N = 3;

        using((register1, register2, target) = (Qubit[N], Qubit[N], Qubit())) {
            // [000], [000]
            FlipIfSame2(register1, register2, target);
            AssertQubit(One, target);
            Reset(target);

            // [100], [000]
            X(register1[0]);
            FlipIfSame2(register1, register2, target);
            AssertQubit(Zero, target);
            
            // [110], [000]
            X(register1[1]);
            FlipIfSame2(register1, register2, target);
            AssertQubit(Zero, target);
            
            // [111], [000]
            X(register1[2]);
            FlipIfSame2(register1, register2, target);
            AssertQubit(One, target);
            Reset(target);

            // [111], [111]
            ApplyToEachA(X, register2);
            FlipIfSame2(register1, register2, target);
            AssertQubit(One, target);
            Reset(target);

            // [000], [111]
            ApplyToEachA(X, register1);
            FlipIfSame2(register1, register2, target);
            AssertQubit(One, target);
            Reset(target);

            ResetAll(register1);
            ResetAll(register2);
        }
    }

    // NOTE: Disabled
    operation MajorityProductOnes_Test() : Unit {
        for(N in 1..3) {
            for (num_ones in 1..N) {
                using((prod1, prod2, target) = (Qubit[N], Qubit[N], Qubit())) {
                    // All 0s -> All prods 1s
                    MajorityProductOnes(prod1, prod2, target);
                    AssertQubit(One, target);
                    Reset(target);

                    ApplyToEachA(X, prod1[0..num_ones - 1]);
                    ApplyToEachA(X, prod2);

                    MajorityProductOnes(prod1, prod2, target);
                    if (num_ones > N / 2) {
                        // Enough ones
                        AssertQubit(One, target);
                    } else {
                        // Not enough ones
                        AssertQubit(Zero, target);
                    }

                    Reset(target);
                    ResetAll(prod1);
                    ResetAll(prod2);
                }
            }
        }
    }

    // NOTE: Disabled
    operation FlipIfAtLeastRecursive_Test() : Unit {
        for(N in 1..10) {
            for (num_ones in 1..N) {
                using((register, target) = (Qubit[N], Qubit())) {
                    // All 0s -> All prods 1s
                    ApplyToEachA(X, register[0..num_ones - 1]);

                    FlipIfAtLeastRecursive(register, target, N);
                    if (num_ones == N) {
                        // Enough ones
                        AssertQubit(One, target);
                    } else {
                        // Not enough ones
                        AssertQubit(Zero, target);
                    }

                    Reset(target);
                    ResetAll(register);
                }
            }
        }
    }

    //
    // Tests for BinaryPerceptronAlgorithm
    //

    // NOTE: Disabled
    operation SimplePredict_AND_Test() : Unit {
        mutable hidden_layers = new Int[0];

        // AND
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [0, 0, 0, 1];
        let weights = [1, 1, 0,    1, 1, 0];

        for (i in 0..Length(input) - 1) {
            let pred = Predict(input[i], hidden_layers, weights);
            AssertIntEqual(pred, labels[i], "Wrong Prediction");
        }
    }

    // NOTE: Disabled
    operation SimplePredict_OR_Test() : Unit {
        mutable hidden_layers = new Int[0];

        // AND
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [0, 1, 1, 1];
        let weights = [1, 1, 1,    1, 1, 1];

        for (i in 0..Length(input) - 1) {
            let pred = Predict(input[i], hidden_layers, weights);
            AssertIntEqual(pred, labels[i], "Wrong Prediction");
        }
    }

    // NOTE: Disabled
    operation Predict_XNOR_Test() : Unit {
        mutable hidden_layers = [2];

        // XNOR
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [1, 0, 0, 1];
        let weights = [0, 1, 1,     1, 0, 1,    1, 1, 0];


        for (i in 0..Length(input) - 1) {
            let pred = Predict(input[i], hidden_layers, weights);
            AssertIntEqual(pred, labels[i], "Wrong Prediction");
        }
    }

    operation TrainModel_Test_Disabled() : Unit {
        let run = 5;
        mutable success = 0;
        for (i in 1..run) {
            set success = success + (RunTrainModel() ? 1 | 0);
        }

        Message("Number of times it worked: ");
        Message(ToStringI(success));

        for (i in 0..5..run) {
            AssertBoolEqual(success >= i, true, "Worked (" + ToStringI(i) + " / " + ToStringI(run) + ") times");
        }
    }

    operation RunTrainModel() : Bool {
        mutable hidden_layers = [2];

        // XNOR
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [1, 0, 0, 1];
        let result_weights = TrainModel(input, labels, hidden_layers, 1.0, -1);
        let N = Length(input);
        
        mutable allCorrect = true;
        for(i in 0..N-1) {
            let pred = Predict(input[i], hidden_layers, result_weights);
            set allCorrect = allCorrect && (pred == labels[i]);
        }
        return allCorrect;
    }
}
