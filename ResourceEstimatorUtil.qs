namespace Quantum.QuantumBNN {
    
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation ResourceEstTrainModel(): Unit {
        mutable hidden_layers = [2];

        // XNOR
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [1, 0, 0, 1];

        let weights = Run_TrainModel(input, labels, hidden_layers, 1.0);
    }

    operation ResourceEstForward(): Unit {
        mutable hidden_layers = [2];

        // XNOR
        let input = [[0,0], [0,1], [1,0], [1,1]];
        let labels = [1, 0, 0, 1];
        let weights = [0, 1, 1,     1, 0, 1,    1, 1, 0];

        let pred = Run_Predict(input[0], hidden_layers, weights);
    }

    operation Run_TrainModel(input: Int[][], labels: Int[], hidden_layers: Int[], accuracy: Double) : Int[] {
        return TrainModel(input, labels, hidden_layers, accuracy, -1);
    }

    operation Run_Predict(input: Int[], hidden_layers: Int[], weights: Int[]) : Int {
        return Predict(input, hidden_layers, weights);
    }

    operation GetAccuracy(input: Int[][], labels: Int[], hidden_layers: Int[], weights: Int[]) : Double {
        return CalculateAccuracy(labels, PredictAll(input, hidden_layers, weights));
    }
}