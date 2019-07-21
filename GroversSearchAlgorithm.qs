namespace Quantum.QuantumBNN {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Diagnostics;

    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (input/query register)
    //      2) a marking oracle, and
    //      3) the number of Grover iterations to perform.
    // Goal: Use Grover's algorithm to leave the input in the state that is marked by the oracle as the answer
    //       (with high probability).
    operation GroversSearch (xs : Qubit[], oracle : ((Qubit[], Qubit) => Unit : Adjoint), iterations : Int) : Unit {
        body (...) {
            let phaseOracle = OracleConverter(oracle);
            
            for (i in 1 .. iterations) {
                GroverIteration(xs, phaseOracle);
            }
        }
        
        adjoint invert;
    }

    // Inputs:
    //      1) N qubits in an arbitrary state |x⟩ (input/query register)
    //      2) a phase-flipping oracle that takes an N-qubit register and flips
    //         the phase of the state if the register is in the desired state.
    // Goal:  Perform one Grover iteration.
    operation GroverIteration (register : Qubit[], oracle : (Qubit[] => Unit : Adjoint)) : Unit {
        
        body (...) {
            // Hint: A Grover iteration consists of 4 steps:
            //    1) apply the oracle
            //    2) apply the Hadamard transform
            //    3) perform a conditional phase shift
            //    4) apply the Hadamard transform again

            oracle(register);
            ApplyToEachA(H, register);
            ConditionalPhaseFlip(register);
            ApplyToEachA(H, register);
        }
        
        adjoint invert;
    }

    // Input: A register of N qubits in an arbitrary state.
    // Goal:  Flip the sign of the state of the register if it is not in the |0...0⟩ state.
    // Example:
    //        If the register is in state |0...0⟩, leave it unchanged.
    //        If the register is in any other basis state, multiply its phase by -1.
    // Note: This operation implements operator 2|0...0⟩⟨0...0| - I.
    operation ConditionalPhaseFlip (register : Qubit[]) : Unit {
        body (...) {
            // Define a marking oracle which detects an all zero state
            let allZerosOracle = Oracle_ArbitraryPattern(_, _, new Bool[Length(register)]);
            
            // Convert it into a phase-flip oracle and apply it
            let flipOracle = OracleConverter(allZerosOracle);
            flipOracle(register);
        }
        adjoint self;
    }
}