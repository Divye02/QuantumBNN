#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetNumCorrectWeights_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GetNumCorrectWeights_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroversSearch_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroversSearch_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_AllOnes\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_AllOnes\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_AllOnes\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":57,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_AllZeros\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_AllZeros\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_AllZeros\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":66,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtleast_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtleast_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BoolBitArrayLE_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BoolBitArrayLE_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":115,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":115,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame2_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":147,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame2_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":147,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"MajorityProductOnes_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":190,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"MajorityProductOnes_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":190,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtLeastRecursive_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtLeastRecursive_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"SimplePredict_AND_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":248,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"SimplePredict_AND_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":248,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"SimplePredict_OR_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":263,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"SimplePredict_OR_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":263,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Predict_XNOR_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":278,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Predict_XNOR_Test\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":278,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"TrainModel_Test_Disabled\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":293,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"TrainModel_Test_Disabled\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":293,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"RunTrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":308,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Bool\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"RunTrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Tests.qs\",\"Position\":{\"Item1\":308,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QuantumBNN
{
    public class GetNumCorrectWeights_Test : Operation<QVoid, QVoid>, ICallable
    {
        public GetNumCorrectWeights_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetNumCorrectWeights_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.GetNumCorrectWeights_Test";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), Int64> GetNumCorrectWeights
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 16 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var hidden_layers = new QArray<Int64>()
            {2L};
#line 19 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 20 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var labels = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 22 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var num_correct_weights = GetNumCorrectWeights.Apply((input?.Copy(), labels?.Copy(), hidden_layers?.Copy(), 1D));
#line 24 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((num_correct_weights, 16L, ("Error while calculating number of correct weights classically" + MicrosoftQuantumExtensionsConvertToStringI.Apply(num_correct_weights))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.GetNumCorrectWeights = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double), Int64>>(typeof(GetNumCorrectWeights));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetNumCorrectWeights_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class GroversSearch_Test : Operation<QVoid, QVoid>, ICallable
    {
        public GroversSearch_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GroversSearch_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.GroversSearch_Test";
        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,IAdjointable,Int64)> GroversSearch
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit)> Oracle_AllOnes
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit)> Oracle_AllZeros
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 33 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var xs = Allocate.Apply(2L);
#line 35 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveH.Apply(xs[0L]);
#line 36 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveH.Apply(xs[1L]);
#line 37 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                GroversSearch.Apply((xs?.Copy(), Oracle_AllOnes, 1L));
#line 38 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, xs[0L]));
#line 39 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, xs[1L]));
#line 40 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                ResetAll.Apply(xs?.Copy());
#line hidden
                Release.Apply(xs);
            }

#line hidden
            {
#line 43 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var xs = Allocate.Apply(2L);
#line 45 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveH.Apply(xs[0L]);
#line 46 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveH.Apply(xs[1L]);
#line 47 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                GroversSearch.Apply((xs?.Copy(), Oracle_AllZeros, 1L));
#line 48 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, xs[0L]));
#line 49 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, xs[1L]));
#line 50 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                ResetAll.Apply(xs?.Copy());
#line hidden
                Release.Apply(xs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.GroversSearch = this.Factory.Get<IAdjointable<(QArray<Qubit>,IAdjointable,Int64)>>(typeof(GroversSearch));
            this.Oracle_AllOnes = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(Oracle_AllOnes));
            this.Oracle_AllZeros = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(Oracle_AllZeros));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<GroversSearch_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Oracle_AllOnes : Adjointable<(QArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_AllOnes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_AllOnes";
        String ICallable.FullName => "Quantum.QuantumBNN.Oracle_AllOnes";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line 56 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((queryRegister?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((queryRegister?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> queryRegister, Qubit target)
        {
            return __m__.Run<Oracle_AllOnes, (QArray<Qubit>,Qubit), QVoid>((queryRegister, target));
        }
    }

    public class Oracle_AllZeros : Adjointable<(QArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_AllZeros(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_AllZeros";
        String ICallable.FullName => "Quantum.QuantumBNN.Oracle_AllZeros";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line 63 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, queryRegister?.Copy()));
#line 64 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((queryRegister?.Copy(), target));
#line 65 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, queryRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, queryRegister?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((queryRegister?.Copy(), target));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, queryRegister?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> queryRegister, Qubit target)
        {
            return __m__.Run<Oracle_AllZeros, (QArray<Qubit>,Qubit), QVoid>((queryRegister, target));
        }
    }

    public class FlipIfAtleast_Test : Operation<QVoid, QVoid>, ICallable
    {
        public FlipIfAtleast_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FlipIfAtleast_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfAtleast_Test";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit,Int64)> FlipIfAtleast
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 77 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var N in new Range(1L, 3L))
#line hidden
            {
#line 78 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                foreach (var num_ones in new Range(1L, N))
#line hidden
                {
#line hidden
                    {
#line 79 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        var (register,target) = (Allocate.Apply(N), Allocate.Apply());
#line 80 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register?.Slice(new Range(0L, (num_ones - 1L)))));
#line 82 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        foreach (var min_N in new Range(0L, (N - 1L)))
#line hidden
                        {
#line 83 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            FlipIfAtleast.Apply((register?.Copy(), target, min_N));
#line 84 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            if ((min_N > num_ones))
                            {
#line 86 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
                            }
                            else
                            {
#line 89 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
                            }

#line 91 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            Reset.Apply(target);
                        }

#line 93 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        Reset.Apply(target);
#line 94 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        ResetAll.Apply(register?.Copy());
#line hidden
                        Release.Apply(register);
#line hidden
                        Release.Apply(target);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.FlipIfAtleast = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Int64)>>(typeof(FlipIfAtleast));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<FlipIfAtleast_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class BoolBitArrayLE_Test : Operation<QVoid, QVoid>, ICallable
    {
        public BoolBitArrayLE_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BoolBitArrayLE_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.BoolBitArrayLE_Test";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> BoolBitArrayLE
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 102 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var N = 5L;
#line 103 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(0L, N))
#line hidden
            {
#line 104 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var result = BoolBitArrayLE.Apply((i, (N + 1L)));
#line 105 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var sum = 0L;
#line 106 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                foreach (var j in new Range(0L, N))
#line hidden
                {
#line 107 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                    if (result[j])
                    {
#line 108 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        sum = (sum + 2L.Pow(j));
                    }
                }

#line 111 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonAssertBoolEqual.Apply(((sum == i), true, "Fail"));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.BoolBitArrayLE = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(BoolBitArrayLE));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<BoolBitArrayLE_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class FlipIfSame_Test : Operation<QVoid, QVoid>, ICallable
    {
        public FlipIfSame_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FlipIfSame_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfSame_Test";
        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit)> FlipIfSame
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 117 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var N = 3L;
#line hidden
            {
#line 119 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var (register,target) = (Allocate.Apply(N), Allocate.Apply());
#line 121 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame.Apply((register?.Copy(), target));
#line 122 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 123 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 126 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(register[0L]);
#line 127 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame.Apply((register?.Copy(), target));
#line 128 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
#line 129 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 132 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(register[1L]);
#line 133 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame.Apply((register?.Copy(), target));
#line 134 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
#line 135 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 138 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(register[2L]);
#line 139 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame.Apply((register?.Copy(), target));
#line 140 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 141 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 143 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                ResetAll.Apply(register?.Copy());
#line hidden
                Release.Apply(register);
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.FlipIfSame = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(FlipIfSame));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<FlipIfSame_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class FlipIfSame2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public FlipIfSame2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FlipIfSame2_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfSame2_Test";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> FlipIfSame2
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 149 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var N = 3L;
#line hidden
            {
#line 151 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var (register1,register2,target) = (Allocate.Apply(N), Allocate.Apply(N), Allocate.Apply());
#line 153 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame2.Apply((register1?.Copy(), register2?.Copy(), target));
#line 154 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 155 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 158 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(register1[0L]);
#line 159 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame2.Apply((register1?.Copy(), register2?.Copy(), target));
#line 160 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
#line 163 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(register1[1L]);
#line 164 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame2.Apply((register1?.Copy(), register2?.Copy(), target));
#line 165 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
#line 168 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumPrimitiveX.Apply(register1[2L]);
#line 169 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame2.Apply((register1?.Copy(), register2?.Copy(), target));
#line 170 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 171 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 174 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line 175 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame2.Apply((register1?.Copy(), register2?.Copy(), target));
#line 176 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 177 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 180 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line 181 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                FlipIfSame2.Apply((register1?.Copy(), register2?.Copy(), target));
#line 182 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 183 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                Reset.Apply(target);
#line 185 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                ResetAll.Apply(register1?.Copy());
#line 186 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                ResetAll.Apply(register2?.Copy());
#line hidden
                Release.Apply(register1);
#line hidden
                Release.Apply(register2);
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.FlipIfSame2 = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(FlipIfSame2));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<FlipIfSame2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class MajorityProductOnes_Test : Operation<QVoid, QVoid>, ICallable
    {
        public MajorityProductOnes_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MajorityProductOnes_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.MajorityProductOnes_Test";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> MajorityProductOnes
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 192 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var N in new Range(1L, 3L))
#line hidden
            {
#line 193 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                foreach (var num_ones in new Range(1L, N))
#line hidden
                {
#line hidden
                    {
#line 194 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        var (prod1,prod2,target) = (Allocate.Apply(N), Allocate.Apply(N), Allocate.Apply());
#line 196 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MajorityProductOnes.Apply((prod1?.Copy(), prod2?.Copy(), target));
#line 197 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
#line 198 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        Reset.Apply(target);
#line 200 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, prod1?.Slice(new Range(0L, (num_ones - 1L)))));
#line 201 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, prod2?.Copy()));
#line 203 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MajorityProductOnes.Apply((prod1?.Copy(), prod2?.Copy(), target));
#line 204 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        if ((num_ones > (N / 2L)))
                        {
#line 206 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
                        }
                        else
                        {
#line 209 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
                        }

#line 212 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        Reset.Apply(target);
#line 213 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        ResetAll.Apply(prod1?.Copy());
#line 214 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        ResetAll.Apply(prod2?.Copy());
#line hidden
                        Release.Apply(prod1);
#line hidden
                        Release.Apply(prod2);
#line hidden
                        Release.Apply(target);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MajorityProductOnes = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(MajorityProductOnes));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<MajorityProductOnes_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class FlipIfAtLeastRecursive_Test : Operation<QVoid, QVoid>, ICallable
    {
        public FlipIfAtLeastRecursive_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "FlipIfAtLeastRecursive_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfAtLeastRecursive_Test";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumExtensionsTestingAssertQubit
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit,Int64)> FlipIfAtLeastRecursive
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 222 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var N in new Range(1L, 10L))
#line hidden
            {
#line 223 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                foreach (var num_ones in new Range(1L, N))
#line hidden
                {
#line hidden
                    {
#line 224 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        var (register,target) = (Allocate.Apply(N), Allocate.Apply());
#line 226 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register?.Slice(new Range(0L, (num_ones - 1L)))));
#line 228 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        FlipIfAtLeastRecursive.Apply((register?.Copy(), target, N));
#line 229 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        if ((num_ones == N))
                        {
#line 231 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.One, target));
                        }
                        else
                        {
#line 234 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                            MicrosoftQuantumExtensionsTestingAssertQubit.Apply((Result.Zero, target));
                        }

#line 237 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        Reset.Apply(target);
#line 238 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                        ResetAll.Apply(register?.Copy());
#line hidden
                        Release.Apply(register);
#line hidden
                        Release.Apply(target);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumExtensionsTestingAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Extensions.Testing.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.FlipIfAtLeastRecursive = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Int64)>>(typeof(FlipIfAtLeastRecursive));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<FlipIfAtLeastRecursive_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class SimplePredict_AND_Test : Operation<QVoid, QVoid>, ICallable
    {
        public SimplePredict_AND_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SimplePredict_AND_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.SimplePredict_AND_Test";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Predict
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 250 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var hidden_layers = new QArray<Int64>(0L);
#line 253 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 254 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var labels = new QArray<Int64>(0L, 0L, 0L, 1L);
#line 255 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var weights = new QArray<Int64>(1L, 1L, 0L, 1L, 1L, 0L);
#line 257 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(0L, (input.Length - 1L)))
#line hidden
            {
#line 258 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var pred = Predict.Apply((input[i], hidden_layers?.Copy(), weights?.Copy()));
#line 259 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((pred, labels[i], "Wrong Prediction"));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Predict));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<SimplePredict_AND_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class SimplePredict_OR_Test : Operation<QVoid, QVoid>, ICallable
    {
        public SimplePredict_OR_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SimplePredict_OR_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.SimplePredict_OR_Test";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Predict
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 265 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var hidden_layers = new QArray<Int64>(0L);
#line 268 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 269 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var labels = new QArray<Int64>(0L, 1L, 1L, 1L);
#line 270 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var weights = new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 1L);
#line 272 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(0L, (input.Length - 1L)))
#line hidden
            {
#line 273 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var pred = Predict.Apply((input[i], hidden_layers?.Copy(), weights?.Copy()));
#line 274 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((pred, labels[i], "Wrong Prediction"));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Predict));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<SimplePredict_OR_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class Predict_XNOR_Test : Operation<QVoid, QVoid>, ICallable
    {
        public Predict_XNOR_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Predict_XNOR_Test";
        String ICallable.FullName => "Quantum.QuantumBNN.Predict_XNOR_Test";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumCanonAssertIntEqual
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Predict
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 280 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var hidden_layers = new QArray<Int64>()
            {2L};
#line 283 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 284 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var labels = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 285 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var weights = new QArray<Int64>(0L, 1L, 1L, 1L, 0L, 1L, 1L, 1L, 0L);
#line 288 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(0L, (input.Length - 1L)))
#line hidden
            {
#line 289 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var pred = Predict.Apply((input[i], hidden_layers?.Copy(), weights?.Copy()));
#line 290 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonAssertIntEqual.Apply((pred, labels[i], "Wrong Prediction"));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Predict));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Predict_XNOR_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class TrainModel_Test_Disabled : Operation<QVoid, QVoid>, ICallable
    {
        public TrainModel_Test_Disabled(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TrainModel_Test_Disabled";
        String ICallable.FullName => "Quantum.QuantumBNN.TrainModel_Test_Disabled";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumCanonAssertBoolEqual
        {
            get;
            set;
        }

        protected ICallable<Int64, String> MicrosoftQuantumExtensionsConvertToStringI
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected ICallable<QVoid, Boolean> RunTrainModel
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 295 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var run = 5L;
#line 296 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var success = 0L;
#line 297 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(1L, run))
#line hidden
            {
#line 298 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                success = (success + (RunTrainModel.Apply(QVoid.Instance) ? 1L : 0L));
            }

#line 301 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            Message.Apply("Number of times it worked: ");
#line 302 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            Message.Apply(MicrosoftQuantumExtensionsConvertToStringI.Apply(success));
#line 304 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(0L, 5L, run))
#line hidden
            {
#line 305 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                MicrosoftQuantumCanonAssertBoolEqual.Apply(((success >= i), true, (((("Worked (" + MicrosoftQuantumExtensionsConvertToStringI.Apply(i)) + " / ") + MicrosoftQuantumExtensionsConvertToStringI.Apply(run)) + ") times")));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertBoolEqual = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertBoolEqual));
            this.MicrosoftQuantumExtensionsConvertToStringI = this.Factory.Get<ICallable<Int64, String>>(typeof(Microsoft.Quantum.Extensions.Convert.ToStringI));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.RunTrainModel = this.Factory.Get<ICallable<QVoid, Boolean>>(typeof(RunTrainModel));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TrainModel_Test_Disabled, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public class RunTrainModel : Operation<QVoid, Boolean>, ICallable
    {
        public RunTrainModel(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RunTrainModel";
        String ICallable.FullName => "Quantum.QuantumBNN.RunTrainModel";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Predict
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>> TrainModel
        {
            get;
            set;
        }

        public override Func<QVoid, Boolean> Body => (__in__) =>
        {
#line 310 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var hidden_layers = new QArray<Int64>()
            {2L};
#line 313 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var input = new QArray<QArray<Int64>>(new QArray<Int64>(0L, 0L), new QArray<Int64>(0L, 1L), new QArray<Int64>(1L, 0L), new QArray<Int64>(1L, 1L));
#line 314 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var labels = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 315 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var result_weights = TrainModel.Apply((input?.Copy(), labels?.Copy(), hidden_layers?.Copy(), 1D, -(1L)));
#line 316 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var N = input.Length;
#line 318 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            var allCorrect = true;
#line 319 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 320 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                var pred = Predict.Apply((input[i], hidden_layers?.Copy(), result_weights?.Copy()));
#line 321 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
                allCorrect = (allCorrect && (pred == labels[i]));
            }

#line 323 "/Users/divye/Documents/projects/QuantumBNN/Tests.qs"
            return allCorrect;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Predict));
            this.TrainModel = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>>>(typeof(TrainModel));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__)
        {
            return __m__.Run<RunTrainModel, QVoid, Boolean>(QVoid.Instance);
        }
    }
}