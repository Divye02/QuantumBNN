#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"PrepareQubitArray\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit_array\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"int_array\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"PrepareQubitArray\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":13,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"PrepareQubitArray\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ReadQubitArray\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit_array\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ReadQubitArray\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComputeNumWeights\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"allLayers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComputeNumWeights\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"CalculateAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"true_labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"predicted_labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"CalculateAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetNumCorrectWeights\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_points\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"accuracy\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":99}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetNumCorrectWeights\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetNumCorrectWeights_helper\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_points\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"true_labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":82},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":111}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num_weights\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":120},\"Item2\":{\"Line\":1,\"Column\":131}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"accuracy\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":137},\"Item2\":{\"Line\":1,\"Column\":145}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetNumCorrectWeights_helper\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetWeightsStartPosition\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"layer_i\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetWeightsStartPosition\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Utils.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QuantumBNN
{
    public class PrepareQubitArray : Adjointable<(QArray<Qubit>,QArray<Int64>)>, ICallable
    {
        public PrepareQubitArray(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "PrepareQubitArray";
        String ICallable.FullName => "Quantum.QuantumBNN.PrepareQubitArray";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (qubit_array,int_array) = __in__;
#line 15 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var N = int_array.Length;
#line 16 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 17 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                if ((int_array[i] == 1L))
                {
#line 18 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qubit_array[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>), QVoid> AdjointBody => (__in__) =>
        {
            var (qubit_array,int_array) = __in__;
#line hidden
            var N = int_array.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                if ((int_array[i] == 1L))
                {
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(qubit_array[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qubit_array, QArray<Int64> int_array)
        {
            return __m__.Run<PrepareQubitArray, (QArray<Qubit>,QArray<Int64>), QVoid>((qubit_array, int_array));
        }
    }

    public class ReadQubitArray : Operation<QArray<Qubit>, QArray<Int64>>, ICallable
    {
        public ReadQubitArray(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ReadQubitArray";
        String ICallable.FullName => "Quantum.QuantumBNN.ReadQubitArray";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QArray<Int64>> Body => (__in__) =>
        {
            var qubit_array = __in__;
#line 28 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var int_array = new QArray<Int64>(qubit_array.Length);
#line 29 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            foreach (var i in new Range(0L, (qubit_array.Length - 1L)))
#line hidden
            {
#line 30 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                if ((M.Apply(qubit_array[i]) == Result.One))
                {
#line 31 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                    int_array[i] = 1L;
                }
            }

#line 34 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            return int_array;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Qubit> qubit_array)
        {
            return __m__.Run<ReadQubitArray, QArray<Qubit>, QArray<Int64>>(qubit_array);
        }
    }

    public class ComputeNumWeights : Function<QArray<Int64>, Int64>, ICallable
    {
        public ComputeNumWeights(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ComputeNumWeights";
        String ICallable.FullName => "Quantum.QuantumBNN.ComputeNumWeights";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, Int64> Body => (__in__) =>
        {
            var allLayers = __in__;
#line 40 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var num_weights = 0L;
#line 41 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            foreach (var i in new Range(1L, (allLayers.Length - 1L)))
#line hidden
            {
#line 42 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                var num_bias = allLayers[i];
#line 43 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                num_weights = ((num_weights + (allLayers[(i - 1L)] * allLayers[i])) + num_bias);
            }

#line 45 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            return num_weights;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> allLayers)
        {
            return __m__.Run<ComputeNumWeights, QArray<Int64>, Int64>(allLayers);
        }
    }

    public class CalculateAccuracy : Operation<(QArray<Int64>,QArray<Int64>), Double>, ICallable
    {
        public CalculateAccuracy(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CalculateAccuracy";
        String ICallable.FullName => "Quantum.QuantumBNN.CalculateAccuracy";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Int64>), Double> Body => (__in__) =>
        {
            var (true_labels,predicted_labels) = __in__;
#line 50 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var N = true_labels.Length;
#line 51 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var num_correct_labels = 0L;
#line 52 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 53 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                if ((predicted_labels[i] == true_labels[i]))
                {
#line 54 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                    num_correct_labels = (num_correct_labels + 1L);
                }
            }

#line 58 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            return (MicrosoftQuantumExtensionsConvertToDouble.Apply(num_correct_labels) / MicrosoftQuantumExtensionsConvertToDouble.Apply(N));
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, QArray<Int64> true_labels, QArray<Int64> predicted_labels)
        {
            return __m__.Run<CalculateAccuracy, (QArray<Int64>,QArray<Int64>), Double>((true_labels, predicted_labels));
        }
    }

    public class GetNumCorrectWeights : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), Int64>, ICallable
    {
        public GetNumCorrectWeights(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetNumCorrectWeights";
        String ICallable.FullName => "Quantum.QuantumBNN.GetNumCorrectWeights";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> ComputeNumWeights
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double), Int64> GetNumCorrectWeights_helper
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), Int64> Body => (__in__) =>
        {
            var (data_points,labels,hidden_layers,accuracy) = __in__;
#line 63 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var num_weights = ComputeNumWeights.Apply(((new QArray<Int64>()
            {data_points[0L].Length} + hidden_layers) + new QArray<Int64>()
            {1L}));
#line 64 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            return GetNumCorrectWeights_helper.Apply((data_points?.Copy(), labels?.Copy(), new QArray<Int64>(0L), hidden_layers?.Copy(), num_weights, accuracy));
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.ComputeNumWeights = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(ComputeNumWeights));
            this.GetNumCorrectWeights_helper = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double), Int64>>(typeof(GetNumCorrectWeights_helper));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<QArray<Int64>> data_points, QArray<Int64> labels, QArray<Int64> hidden_layers, Double accuracy)
        {
            return __m__.Run<GetNumCorrectWeights, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), Int64>((data_points, labels, hidden_layers, accuracy));
        }
    }

    public class GetNumCorrectWeights_helper : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double), Int64>, ICallable
    {
        public GetNumCorrectWeights_helper(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetNumCorrectWeights_helper";
        String ICallable.FullName => "Quantum.QuantumBNN.GetNumCorrectWeights_helper";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double), Int64> self
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>> PredictAll
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double), Int64> Body => (__in__) =>
        {
            var (data_points,true_labels,weights,hidden_layers,num_weights,accuracy) = __in__;
#line 68 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            if ((num_weights == weights.Length))
            {
#line 69 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                var predicted = PredictAll.Apply((data_points?.Copy(), hidden_layers?.Copy(), weights?.Copy()));
#line 70 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                var num_correct_labels = 0L;
#line 71 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                foreach (var i in new Range(0L, (predicted.Length - 1L)))
#line hidden
                {
#line 72 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                    if ((predicted[i] == true_labels[i]))
                    {
#line 73 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                        num_correct_labels = (num_correct_labels + 1L);
                    }
                }

#line 76 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                if ((MicrosoftQuantumExtensionsConvertToDouble.Apply(num_correct_labels) >= (accuracy * MicrosoftQuantumExtensionsConvertToDouble.Apply(data_points.Length))))
                {
#line 77 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                    return 1L;
                }

#line 79 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                return 0L;
            }
            else
            {
#line 81 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                return (self.Apply<Int64>((data_points?.Copy(), true_labels?.Copy(), (weights + new QArray<Int64>()
                {0L}), hidden_layers?.Copy(), num_weights, accuracy)) + self.Apply<Int64>((data_points?.Copy(), true_labels?.Copy(), (weights + new QArray<Int64>()
                {1L}), hidden_layers?.Copy(), num_weights, accuracy)));
            }
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.self = this;
            this.PredictAll = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>>>(typeof(PredictAll));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<QArray<Int64>> data_points, QArray<Int64> true_labels, QArray<Int64> weights, QArray<Int64> hidden_layers, Int64 num_weights, Double accuracy)
        {
            return __m__.Run<GetNumCorrectWeights_helper, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,QArray<Int64>,Int64,Double), Int64>((data_points, true_labels, weights, hidden_layers, num_weights, accuracy));
        }
    }

    public class GetWeightsStartPosition : Function<(QArray<Int64>,Int64), Int64>, ICallable
    {
        public GetWeightsStartPosition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,Int64)>, IApplyData
        {
            public In((QArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GetWeightsStartPosition";
        String ICallable.FullName => "Quantum.QuantumBNN.GetWeightsStartPosition";
        public override Func<(QArray<Int64>,Int64), Int64> Body => (__in__) =>
        {
            var (layers,layer_i) = __in__;
#line 87 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            var pos = 0L;
#line 88 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            foreach (var i in new Range(1L, (layer_i - 1L)))
#line hidden
            {
#line 89 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
                pos = ((pos + (layers[(i - 1L)] * layers[i])) + layers[i]);
            }

#line 91 "/Users/divye/Documents/projects/QuantumBNN/Utils.qs"
            return pos;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> layers, Int64 layer_i)
        {
            return __m__.Run<GetWeightsStartPosition, (QArray<Int64>,Int64), Int64>((layers, layer_i));
        }
    }
}