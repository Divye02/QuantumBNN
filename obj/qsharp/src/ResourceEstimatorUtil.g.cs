#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ResourceEstTrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ResourceEstTrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ResourceEstForward\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ResourceEstForward\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Run_TrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":70}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"accuracy\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":87}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Run_TrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Run_Predict\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Run_Predict\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":83}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QuantumBNN
{
    public class ResourceEstTrainModel : Operation<QVoid, QVoid>, ICallable
    {
        public ResourceEstTrainModel(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResourceEstTrainModel";
        String ICallable.FullName => "Quantum.QuantumBNN.ResourceEstTrainModel";
        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), QArray<Int64>> Run_TrainModel
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 10 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var hidden_layers = new QArray<Int64>()
            {2L};
#line 13 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 14 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var labels = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 16 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var weights = Run_TrainModel.Apply((input?.Copy(), labels?.Copy(), hidden_layers?.Copy(), 1D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Run_TrainModel = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), QArray<Int64>>>(typeof(Run_TrainModel));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<ResourceEstTrainModel, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class ResourceEstForward : Operation<QVoid, QVoid>, ICallable
    {
        public ResourceEstForward(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResourceEstForward";
        String ICallable.FullName => "Quantum.QuantumBNN.ResourceEstForward";
        protected ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Run_Predict
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 20 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var hidden_layers = new QArray<Int64>()
            {2L};
#line 23 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 24 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var labels = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 25 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var weights = new QArray<Int64>(0L, 1L, 1L, 1L, 0L, 1L, 1L, 1L, 0L);
#line 27 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            var pred = Run_Predict.Apply((input[0L], hidden_layers?.Copy(), weights?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Run_Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Run_Predict));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<ResourceEstForward, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Run_TrainModel : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), QArray<Int64>>, ICallable
    {
        public Run_TrainModel(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Run_TrainModel";
        String ICallable.FullName => "Quantum.QuantumBNN.Run_TrainModel";
        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>> TrainModel
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), QArray<Int64>> Body => (__in__) =>
        {
            var (input,labels,hidden_layers,accuracy) = __in__;
#line 31 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            return TrainModel.Apply((input?.Copy(), labels?.Copy(), hidden_layers?.Copy(), accuracy, -(1L)));
        }

        ;
        public override void Init()
        {
            this.TrainModel = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>>>(typeof(TrainModel));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<QArray<Int64>> input, QArray<Int64> labels, QArray<Int64> hidden_layers, Double accuracy)
        {
            return __m__.Run<Run_TrainModel, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), QArray<Int64>>((input, labels, hidden_layers, accuracy));
        }
    }

    public class Run_Predict : Operation<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>, ICallable
    {
        public Run_Predict(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Run_Predict";
        String ICallable.FullName => "Quantum.QuantumBNN.Run_Predict";
        protected ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Predict
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Body => (__in__) =>
        {
            var (input,hidden_layers,weights) = __in__;
#line 35 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            return Predict.Apply((input?.Copy(), hidden_layers?.Copy(), weights?.Copy()));
        }

        ;
        public override void Init()
        {
            this.Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Predict));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> input, QArray<Int64> hidden_layers, QArray<Int64> weights)
        {
            return __m__.Run<Run_Predict, (QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>((input, hidden_layers, weights));
        }
    }

    public class GetAccuracy : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>), Double>, ICallable
    {
        public GetAccuracy(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetAccuracy";
        String ICallable.FullName => "Quantum.QuantumBNN.GetAccuracy";
        protected ICallable<(QArray<Int64>,QArray<Int64>), Double> CalculateAccuracy
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>> PredictAll
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>), Double> Body => (__in__) =>
        {
            var (input,labels,hidden_layers,weights) = __in__;
#line 39 "/Users/divye/Documents/projects/QuantumBNN/ResourceEstimatorUtil.qs"
            return CalculateAccuracy.Apply((labels?.Copy(), PredictAll.Apply((input?.Copy(), hidden_layers?.Copy(), weights?.Copy()))));
        }

        ;
        public override void Init()
        {
            this.CalculateAccuracy = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>), Double>>(typeof(CalculateAccuracy));
            this.PredictAll = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>>>(typeof(PredictAll));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, QArray<QArray<Int64>> input, QArray<Int64> labels, QArray<Int64> hidden_layers, QArray<Int64> weights)
        {
            return __m__.Run<GetAccuracy, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>), Double>((input, labels, hidden_layers, weights));
        }
    }
}