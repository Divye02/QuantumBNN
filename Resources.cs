using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using System.Collections.Generic;
using System.IO;

namespace Quantum.QuantumBNN
{
    class Resources
    {
        static void Main(string[] args)
        {
            if (args.Length == 1) {
                ResourceEstimator();
            } else {
                RunBNN();
            }
        }

        public static void ResourceEstimator() {
            ResourcesEstimator sim = new ResourcesEstimator();
            ResourceEstTrainModel.Run(sim).Wait();
            var stats = sim.ToTSV();
            System.Console.Write("\n" + stats + "\n");
        }

        public static void RunBNN() {
            var sim = new QuantumSimulator();
            Console.WriteLine("Please enter the number of training data points: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            QArray<QArray<long>> data_points = new QArray<QArray<long>>();

            QArray<long> labels = new QArray<long>();
            Console.WriteLine("Please enter the input data and label on each line :");
            for (int i = 0; i < n; i++) {

                QArray<long> data_point = new QArray<long>();
                string line = Console.ReadLine();
                string[] numbers = line.Trim(' ').Split(' ');
                int last = numbers.Length - 1;
                for (int j = 0; j < last; j++) {
                    data_point.Add(Convert.ToInt64(numbers[j]));
                }
                data_points.Add(data_point);
                labels.Add(Convert.ToInt64(numbers[last]));
            }



            Console.WriteLine();
            QArray<long> hidden_layers = new QArray<long>();
            Console.WriteLine("Please enter the number of nodes in each hidden layer :");

            string[] hidden = Console.ReadLine().Trim(' ').Split(' ');
            for (int i = 0; i < hidden.Length; i++) {
                long h = Convert.ToInt64(hidden[i]);
                if (h != 0) {
                    hidden_layers.Add(h);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Please enter the desired accuracy :");
            double desired_accuracy = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Data points: ");
            for (int i = 0; i < data_points.Length; i++) {
                Console.WriteLine("[" + string.Join(", ", data_points[i]) + "]");
            }
            Console.WriteLine("Labels : " + "[" + string.Join(", ", labels) + "]");
            Console.WriteLine("Hidden Layers: " + "[" + string.Join(", ", hidden_layers) + "]");
            Console.WriteLine("Desired accuracy: " + desired_accuracy);

            Console.WriteLine();
            Console.WriteLine("Training");
            QArray<long> weights = Run_TrainModel.Run(sim, data_points, labels, hidden_layers, desired_accuracy).Result;
            Console.WriteLine("Model trained");
            double result_accuracy = GetAccuracy.Run(sim, data_points, labels, hidden_layers, weights).Result;
            Console.WriteLine("Achieved accuracy: " + result_accuracy);
            QArray<long> weights_pos_neg = new QArray<long>();
            for (int i = 0; i < weights.Length; i++) {
                if(weights[i] == 1) {
                    weights_pos_neg.Add(weights[i]);
                } else {
                    weights_pos_neg.Add(-1);
                }

            }
            Console.WriteLine("Weights: " + "[" + string.Join(", ", weights) + "]" + " ----> " + "[" + string.Join(", ", weights_pos_neg) + "]" );


            string output_file = @"weights.txt";
            if (File.Exists(output_file)) 
            {
                File.Delete(output_file);
            }
            Console.WriteLine("Weights are in: " + output_file);
            Console.WriteLine("You may run the viz tool now: python viz_net.py");
            using (System.IO.StreamWriter file =  new System.IO.StreamWriter(output_file, true))
            {
                file.WriteLine(string.Join(" ", weights));
                file.WriteLine(string.Join(" ", hidden_layers));
                file.WriteLine(data_points[0].Length);
                file.WriteLine(1);
            }
            while(true) {
                Console.WriteLine();
                QArray<long> pred_data = new QArray<long>();
                Console.WriteLine("Input data point for Prediction: ");

                string[] pred_data_points = Console.ReadLine().Trim(' ').Split(' ');
                for (int i = 0; i < pred_data_points.Length; i++) {
                    pred_data.Add(Convert.ToInt64(pred_data_points[i]));
                }

                long prediction = Run_Predict.Run(sim, pred_data, hidden_layers, weights).Result;
                Console.WriteLine("Prediction: " + prediction);

                Console.WriteLine();
            }
        }
    }
}
