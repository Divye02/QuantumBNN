#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"xs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"iterations\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":97}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":23,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":46,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ConditionalPhaseFlip\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ConditionalPhaseFlip\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":56,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ConditionalPhaseFlip\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs\",\"Position\":{\"Item1\":64,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QuantumBNN
{
    public class GroversSearch : Adjointable<(QArray<Qubit>,IAdjointable,Int64)>, ICallable
    {
        public GroversSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,IAdjointable,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GroversSearch";
        String ICallable.FullName => "Quantum.QuantumBNN.GroversSearch";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,IAdjointable)> GroverIteration
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (xs,oracle,iterations) = __in__;
#line 17 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            var phaseOracle = OracleConverter.Apply(oracle);
#line 19 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            foreach (var i in new Range(1L, iterations))
#line hidden
            {
#line 20 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
                GroverIteration.Apply((xs?.Copy(), phaseOracle));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,IAdjointable,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (xs,oracle,iterations) = __in__;
#line hidden
            var phaseOracle = OracleConverter.Apply(oracle);
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, iterations)))
#line hidden
            {
#line hidden
                GroverIteration.Adjoint.Apply((xs?.Copy(), phaseOracle));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.GroverIteration = this.Factory.Get<IAdjointable<(QArray<Qubit>,IAdjointable)>>(typeof(GroverIteration));
            this.OracleConverter = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter));
        }

        public override IApplyData __dataIn((QArray<Qubit>,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> xs, IAdjointable oracle, Int64 iterations)
        {
            return __m__.Run<GroversSearch, (QArray<Qubit>,IAdjointable,Int64), QVoid>((xs, oracle, iterations));
        }
    }

    public class GroverIteration : Adjointable<(QArray<Qubit>,IAdjointable)>, ICallable
    {
        public GroverIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((QArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GroverIteration";
        String ICallable.FullName => "Quantum.QuantumBNN.GroverIteration";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> ConditionalPhaseFlip
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (register,oracle) = __in__;
#line 41 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            oracle.Apply(register?.Copy());
#line 42 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, register?.Copy()));
#line 43 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            ConditionalPhaseFlip.Apply(register?.Copy());
#line 44 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, register?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (register,oracle) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, register?.Copy()));
#line hidden
            ConditionalPhaseFlip.Adjoint.Apply(register?.Copy());
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveH, register?.Copy()));
#line hidden
            oracle.Adjoint.Apply(register?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.ConditionalPhaseFlip = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(ConditionalPhaseFlip));
        }

        public override IApplyData __dataIn((QArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, IAdjointable oracle)
        {
            return __m__.Run<GroverIteration, (QArray<Qubit>,IAdjointable), QVoid>((register, oracle));
        }
    }

    public class ConditionalPhaseFlip : Adjointable<QArray<Qubit>>, ICallable
    {
        public ConditionalPhaseFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ConditionalPhaseFlip";
        String ICallable.FullName => "Quantum.QuantumBNN.ConditionalPhaseFlip";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit,QArray<Boolean>)> Oracle_ArbitraryPattern
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 59 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            var allZerosOracle = Oracle_ArbitraryPattern.Partial(new Func<(QArray<Qubit>,Qubit), (QArray<Qubit>,Qubit,QArray<Boolean>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, new QArray<Boolean>(register.Length))));
#line 62 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            var flipOracle = OracleConverter.Apply(allZerosOracle);
#line 63 "/Users/divye/Documents/projects/QuantumBNN/GroversSearchAlgorithm.qs"
            flipOracle.Apply(register?.Copy());
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.OracleConverter = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter));
            this.Oracle_ArbitraryPattern = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,QArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register)
        {
            return __m__.Run<ConditionalPhaseFlip, QArray<Qubit>, QVoid>(register);
        }
    }
}