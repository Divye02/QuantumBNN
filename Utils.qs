namespace Quantum.QuantumBNN {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Diagnostics;

    // Prepare a qubit array from an int array.
    //  qubit_array     : The qubit array to be prepared.
    //                      NOTE: Has to be oin the 0 state initally.
    //  int_array       : The int array representation the output qubit state.
    operation PrepareQubitArray(qubit_array: Qubit[], int_array: Int[]): Unit {
        body (...) {
            let N = Length(int_array);
            for(i in 0..N-1) {
                if(int_array[i] == 1) {
                    X(qubit_array[i]);
                }
            }
        }
        adjoint auto;
    }

    // Prepare a int array from an qubit array.
    //  qubit_array     : The qubit array to be read.
    operation ReadQubitArray(qubit_array: Qubit[]): Int[] {
        mutable int_array = new Int[Length(qubit_array)];
        for (i in 0..Length(qubit_array) - 1) {
            if(M(qubit_array[i]) == One) {
                set int_array[i] = 1;
            }
        }
        return int_array;
    }

    // Compute the number of weights (including bias) required by the hidden dimensions.
    //  allLayers      : The layers
    function ComputeNumWeights(allLayers: Int[]) : Int {
        mutable num_weights = 0;
        for (i in 1..Length(allLayers) - 1) {
            let num_bias = allLayers[i];
            set num_weights = num_weights + (allLayers[i - 1] * allLayers[i]) + num_bias;
        }
        return num_weights;
    }

    // Calculates the accuracy percentage given the true and predicted labels.
    operation CalculateAccuracy(true_labels: Int[], predicted_labels: Int[]) : Double {
        let N = Length(true_labels);
        mutable num_correct_labels = 0;
        for (i in 0..N - 1) {
            if (predicted_labels[i] == true_labels[i]) {
                set num_correct_labels = num_correct_labels + 1;
            }
        }

        return ToDouble(num_correct_labels) / ToDouble(N);
    }

    // Count number of correct weights classically.
    operation GetNumCorrectWeights(data_points: Int[][], labels: Int[], hidden_layers: Int[], accuracy: Double) : Int {
        let num_weights = ComputeNumWeights([Length(data_points[0])] + hidden_layers + [1]);
        return GetNumCorrectWeights_helper(data_points, labels, new Int[0], hidden_layers, num_weights, accuracy);
    }

    operation GetNumCorrectWeights_helper(data_points: Int[][], true_labels: Int[],  weights: Int[], hidden_layers: Int[], num_weights:Int, accuracy: Double) : Int {
        if (num_weights == Length(weights)) {
            let predicted = PredictAll(data_points, hidden_layers, weights);
            mutable num_correct_labels = 0;
            for (i in 0..Length(predicted) - 1) {
                if (predicted[i] == true_labels[i]) {
                    set num_correct_labels = num_correct_labels + 1;
                }
            }
            if (ToDouble(num_correct_labels) >= accuracy * ToDouble(Length(data_points))) {
                return 1;
            }
            return 0;
        } else {
            return GetNumCorrectWeights_helper(data_points, true_labels, weights + [0], hidden_layers, num_weights, accuracy) +
                    GetNumCorrectWeights_helper(data_points, true_labels, weights + [1], hidden_layers, num_weights, accuracy);
        }
    }

    function GetWeightsStartPosition(layers: Int[], layer_i: Int) : Int {
        mutable pos = 0;
        for (i in 1..layer_i - 1) {
            set pos = pos + layers[i - 1] * layers[i] + layers[i];
        }
        return pos;
    }


    // TODO : Create interface for input data points, labels and hidden layer dimensions that can be passed to Predict.
}