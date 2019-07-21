namespace Quantum.QuantumBNN {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Diagnostics;

    // Trains the model on the given data points and labels.
    // Returns the weights that classify the given data points with at least the given accuracy.
    // If num_correct_weights == -1, try all iterations.
    operation TrainModel(data_points: Int[][], labels: Int[], hidden_layers: Int[], accuracy: Double, num_correct_weights: Int) : Int[] {
        AssertIntEqual(Length(data_points), Length(labels), "The number of data points and labels given are not equal");
        
        let input_dim = [Length(data_points[0])];
        let output_dim = [1];
        let allLayers = input_dim + hidden_layers + output_dim;
        mutable num_weights = ComputeNumWeights(allLayers);

        if (num_correct_weights !=  -1) {
            return TrainModel_ForNumIter(data_points, labels, allLayers, num_weights, accuracy, num_correct_weights);
        }

        let num_weight_states = ToDouble(2 ^ num_weights);
        let max_num_iter = Floor((PI() / 4.0) * Sqrt(num_weight_states));
        let max_tries_per_iter = 3;

        for (num_iter in 1..max_num_iter) {
            for (i in 1..max_tries_per_iter) {
                let weights = TrainModel_ForNumIter(data_points, labels, allLayers, num_weights, accuracy, num_iter);
                let predictions = PredictAll(data_points, hidden_layers, weights);
                if (CalculateAccuracy(labels, predictions) >= accuracy) {
                    return weights;
                }
            }
        }

        return new Int[0];
    }

    // Trains the model on the given data points and labels.
    // Returns the weights that classify the given data points with at least the given accuracy.
    operation TrainModel_ForNumIter(data_points: Int[][], labels: Int[], allLayers: Int[], num_weights: Int, accuracy: Double, num_iter: Int) : Int[] {
        mutable result_weights = new Int[0];
        using(weights = (Qubit[num_weights])) {
            // Get superposition of all the weights
            ApplyToEachA(H, weights);

            GroversSearch(weights, BNNMarkingOracleWithDesiredAccuracy(_, accuracy, allLayers, data_points, labels, _), num_iter);
            set result_weights = ReadQubitArray(weights);

            ResetAll(weights);
        }
        return result_weights;
    }

    operation Forward_IntData(weights: Qubit[], allLayers: Int[], data_point_int: Int[], label: Int, target: Qubit) : Unit {
        body(...) {
            using((data_point_qubit, label_qubit, bias) = (Qubit[Length(data_point_int)], Qubit(), Qubit())) {
                PrepareQubitArray(data_point_qubit, data_point_int);
                PrepareQubitArray([label_qubit], [label]);
                X(bias);

                Forward(weights, allLayers, data_point_qubit + [bias], label_qubit, 1, target, true);
                
                //
                // Un-entangle
                //

                X(bias);
                PrepareQubitArray([label_qubit], [label]);
                PrepareQubitArray(data_point_qubit, data_point_int);
            }
        }
        adjoint auto;
    }

    operation Forward(weights: Qubit[], allLayers: Int[], data_point: Qubit[], actual_label: Qubit, current_layer_i: Int, prediction: Qubit, in_train_mode : Bool) : Unit {
        body (...) {
            if (current_layer_i == Length(allLayers)) {
                // Make a prediction
                if (in_train_mode) {
                    FlipIfSame([data_point[0], actual_label], prediction);
                } else {
                    CNOT(data_point[0], prediction);
                }
            } else {
                let i = current_layer_i;
                using (layer_out = Qubit[allLayers[i] + 1]) {
                    let weights_i = WeightsLayerI(weights, allLayers, i);
                    
                    // Bias term for next layer
                    X(layer_out[allLayers[i]]);
                    ForwardSingleLayer(weights_i, allLayers[i - 1 .. i], data_point, layer_out);
                    
                    Forward(weights, allLayers, layer_out, actual_label, i + 1, prediction, in_train_mode);
                    
                    //
                    // Un-entangle
                    //
                    
                    X(layer_out[allLayers[i]]);
                    Adjoint ForwardSingleLayer(weights_i, allLayers[i - 1 .. i], data_point, layer_out);
                }
            }
        }  
        adjoint auto;
    }


    // Get the starting index of the weights for layer_i
    function WeightsLayerI(weights : Qubit[], layers : Int[], layer_i: Int) : Qubit[] {
        let len_weights_i = layers[layer_i - 1] * layers[layer_i] + layers[layer_i];
        let pos = GetWeightsStartPosition(layers, layer_i);
        return weights[pos..pos + len_weights_i - 1];
    }


    operation ForwardSingleLayer(weights: Qubit[], layer: Int[], input: Qubit[], output: Qubit[]) : Unit {
        body (...) {
            for(i in 0..layer[1] - 1) {
                let start_w = i * (layer[0] + 1);
                let end_w = start_w + (layer[0] + 1);

                MajorityProductOnes(weights[start_w..end_w-1], input, output[i]);
            }
        }
        adjoint auto;
    }

    operation Predict(data_point_int: Int[], hidden_layers: Int[], weights_int: Int[]) : Int {

        let input_dim = [Length(data_point_int)];
        let output_dim = [1];
        let allLayers = input_dim + hidden_layers + output_dim;

        mutable prediction = -1;
        using((data_point, weights, bias, unknown_label) = (Qubit[Length(data_point_int)], Qubit[Length(weights_int)], Qubit(), Qubit())) {

            PrepareQubitArray(data_point, data_point_int);
            PrepareQubitArray(weights, weights_int);
            X(bias);

            Forward(weights, allLayers, data_point + [bias], unknown_label, 1, unknown_label, false);
            set prediction = M(unknown_label) == One ? 1 | 0;

            ResetAll(data_point);
            ResetAll(weights);
            Reset(bias);
            Reset(unknown_label);
        }
        return prediction;
    }

    operation PredictAll(data_points_int: Int[][], hidden_layers: Int[], weights_int: Int[]) : Int[] {
        let N = Length(data_points_int);
        mutable predictions = new Int[N];
        for (i in 0..N - 1) {
            set predictions[i] = Predict(data_points_int[i], hidden_layers, weights_int);
        }
        return predictions;
    }
}
