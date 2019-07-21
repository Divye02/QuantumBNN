#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtleast\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"min_N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtleast\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtleast\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"AdderBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":73,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"A\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"B\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"AdderBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":74,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"AdderBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":89,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"AdderBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":90,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"AdderBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":91,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComparatorBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"d\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"dmax\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComparatorBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComparatorBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":112,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComparatorBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":113,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ComparatorBE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":114,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":117,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"},{\"Case\":\"Controlled\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":118,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":121,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":122,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Rzk\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":123,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BoolBitArrayLE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num_bits\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":43}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BoolBitArrayLE\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":153,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":154,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":161,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame2\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":169,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame2\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":170,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfSame2\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":187,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"MajorityProductOnes\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":198,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"xs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"MajorityProductOnes\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":199,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"MajorityProductOnes\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":235,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BNNMarkingOracleWithDesiredAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":246,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"accuracy\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":73}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"allLayers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":92}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":101},\"Item2\":{\"Line\":1,\"Column\":106}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":117},\"Item2\":{\"Line\":1,\"Column\":123}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":132},\"Item2\":{\"Line\":1,\"Column\":138}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Double\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BNNMarkingOracleWithDesiredAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":247,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"BNNMarkingOracleWithDesiredAccuracy\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":272,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtLeastRecursive\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":281,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"min_N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":73}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtLeastRecursive\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":282,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"FlipIfAtLeastRecursive\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":285,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ControlledOnBitStringWithMinTrue\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":288,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bool_array\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"minTrue\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":105}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ControlledOnBitStringWithMinTrue\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":289,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ControlledOnBitStringWithMinTrue\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":299,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"OracleConverter\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":306,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"OracleConverter\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":306,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"OracleConverterImpl\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":310,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":85},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},[{\"Case\":\"Adjoint\"}]]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"OracleConverterImpl\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":311,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"OracleConverterImpl\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":326,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_ArbitraryPattern\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":329,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":75},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_ArbitraryPattern\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":330,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Oracle_ArbitraryPattern\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/Oracles.qs\",\"Position\":{\"Item1\":333,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QuantumBNN
{
    public class FlipIfAtleast : Adjointable<(QArray<Qubit>,Qubit,Int64)>, ICallable
    {
        public FlipIfAtleast(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "FlipIfAtleast";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfAtleast";
        protected ICallable<QVoid, Double> MicrosoftQuantumCanonLogOf2
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonReverse
        {
            get;
            set;
        }

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

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathFloor
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> AdderBE
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QArray<Boolean>> BoolBitArrayLE
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)> ComparatorBE
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (register,target,min_N) = __in__;
#line 17 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var N = register.Length;
#line 18 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var n_bits = (MicrosoftQuantumExtensionsMathFloor.Apply((MicrosoftQuantumExtensionsMathLog.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N)) / MicrosoftQuantumCanonLogOf2.Apply(QVoid.Instance))) + 1L);
#line hidden
            {
#line 20 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var (running_sum,sum,current_bit) = (Allocate.Apply((n_bits + 2L)), Allocate.Apply((n_bits + 2L)), Allocate.Apply((n_bits + 2L)));
#line 23 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveX.Apply(current_bit[(current_bit.Length - 1L)]);
#line 24 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                AdderBE.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line 25 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveX.Apply(current_bit[(current_bit.Length - 1L)]);
#line 28 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 29 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
#line 31 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    AdderBE.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line 32 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
                }

#line 36 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var bit_array = MicrosoftQuantumCanonReverse.Apply<QArray<Boolean>>(BoolBitArrayLE.Apply((min_N, (n_bits + 2L))));
#line 37 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (bit_array.Length - 1L)))
#line hidden
                {
#line 38 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    if (bit_array[i])
                    {
#line 39 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        MicrosoftQuantumPrimitiveX.Apply(sum[i]);
                    }
                }

#line 44 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                ComparatorBE.Apply((running_sum?.Copy(), sum?.Copy(), target));
#line 50 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (bit_array.Length - 1L)))
#line hidden
                {
#line 51 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    if (bit_array[i])
                    {
#line 52 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        MicrosoftQuantumPrimitiveX.Apply(sum[i]);
                    }
                }

#line 56 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveX.Apply(current_bit[(current_bit.Length - 1L)]);
#line 57 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                AdderBE.Adjoint.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line 58 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveX.Apply(current_bit[(current_bit.Length - 1L)]);
#line 59 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 60 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
#line 62 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    AdderBE.Adjoint.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line 63 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
                }

#line hidden
                Release.Apply(running_sum);
#line hidden
                Release.Apply(sum);
#line hidden
                Release.Apply(current_bit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (register,target,min_N) = __in__;
#line hidden
            var N = register.Length;
#line hidden
            var n_bits = (MicrosoftQuantumExtensionsMathFloor.Apply((MicrosoftQuantumExtensionsMathLog.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(N)) / MicrosoftQuantumCanonLogOf2.Apply(QVoid.Instance))) + 1L);
#line hidden
            {
#line hidden
                var (running_sum,sum,current_bit) = (Allocate.Apply((n_bits + 2L)), Allocate.Apply((n_bits + 2L)), Allocate.Apply((n_bits + 2L)));
#line hidden
                var bit_array = MicrosoftQuantumCanonReverse.Apply<QArray<Boolean>>(BoolBitArrayLE.Apply((min_N, (n_bits + 2L))));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
#line hidden
                    AdderBE.Adjoint.Adjoint.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
                }

#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(current_bit[(current_bit.Length - 1L)]);
#line hidden
                AdderBE.Adjoint.Adjoint.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(current_bit[(current_bit.Length - 1L)]);
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (bit_array.Length - 1L))))
#line hidden
                {
#line hidden
                    if (bit_array[i])
                    {
#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Apply(sum[i]);
                    }
                }

#line hidden
                ComparatorBE.Adjoint.Apply((running_sum?.Copy(), sum?.Copy(), target));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (bit_array.Length - 1L))))
#line hidden
                {
#line hidden
                    if (bit_array[i])
                    {
#line hidden
                        MicrosoftQuantumPrimitiveX.Adjoint.Apply(sum[i]);
                    }
                }

#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
#line hidden
                    AdderBE.Adjoint.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((register[i], current_bit[(current_bit.Length - 1L)]));
                }

#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(current_bit[(current_bit.Length - 1L)]);
#line hidden
                AdderBE.Adjoint.Apply((running_sum?.Copy(), current_bit?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(current_bit[(current_bit.Length - 1L)]);
#line hidden
                Release.Apply(running_sum);
#line hidden
                Release.Apply(sum);
#line hidden
                Release.Apply(current_bit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonLogOf2 = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Canon.LogOf2));
            this.MicrosoftQuantumCanonReverse = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.Reverse<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathFloor = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Floor));
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.AdderBE = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(AdderBE));
            this.BoolBitArrayLE = this.Factory.Get<ICallable<(Int64,Int64), QArray<Boolean>>>(typeof(BoolBitArrayLE));
            this.ComparatorBE = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(ComparatorBE));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, Qubit target, Int64 min_N)
        {
            return __m__.Run<FlipIfAtleast, (QArray<Qubit>,Qubit,Int64), QVoid>((register, target, min_N));
        }
    }

    public class AdderBE : Unitary<(QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public AdderBE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AdderBE";
        String ICallable.FullName => "Quantum.QuantumBNN.AdderBE";
        protected IUnitary<Microsoft.Quantum.Canon.BigEndian> MicrosoftQuantumCanonQFT
        {
            get;
            set;
        }

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

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Double)> Rzk
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (A,B) = __in__;
#line 77 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var N = A.Length;
#line 78 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var P = B.Length;
#line 79 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            if ((N != P))
            {
#line 80 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                throw new ExecutionFailException("Eror: improper quantum AdderBE usage");
            }

#line 82 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonQFT.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
#line 83 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 84 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var j in new Range(0L, i))
#line hidden
                {
#line 85 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    Rzk.Controlled.Apply((new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L)))));
                }
            }

#line 88 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonQFT.Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (A,B) = __in__;
#line hidden
            var N = A.Length;
#line hidden
            var P = B.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper quantum AdderBE usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, i)))
#line hidden
                {
#line hidden
                    Rzk.Controlled.Adjoint.Apply((new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L)))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Apply(new Microsoft.Quantum.Canon.BigEndian(A?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(A,B)) = __in__;
#line hidden
            var N = A.Length;
#line hidden
            var P = B.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper quantum AdderBE usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line hidden
                foreach (var j in new Range(0L, i))
#line hidden
                {
#line hidden
                    Rzk.Controlled.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L))))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(A,B)) = __in__;
#line hidden
            var N = A.Length;
#line hidden
            var P = B.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper quantum AdderBE usage");
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, i)))
#line hidden
                {
#line hidden
                    Rzk.Controlled.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>()
                    {A[((N - j) - 1L)]}, (B[i], MicrosoftQuantumExtensionsConvertToDouble.Apply(((i - j) + 1L))))));
                }
            }

#line hidden
            MicrosoftQuantumCanonQFT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), new Microsoft.Quantum.Canon.BigEndian(A?.Copy())));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonQFT = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.BigEndian>>(typeof(Microsoft.Quantum.Canon.QFT));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.Rzk = this.Factory.Get<IUnitary<(Qubit,Double)>>(typeof(Rzk));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> A, QArray<Qubit> B)
        {
            return __m__.Run<AdderBE, (QArray<Qubit>,QArray<Qubit>), QVoid>((A, B));
        }
    }

    public class ComparatorBE : Unitary<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public ComparatorBE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ComparatorBE";
        String ICallable.FullName => "Quantum.QuantumBNN.ComparatorBE";
        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<(QArray<Qubit>,QArray<Qubit>)> AdderBE
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (d,dmax,target) = __in__;
#line 98 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var N = d.Length;
#line 99 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var P = dmax.Length;
#line 100 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            if ((N != P))
            {
#line 101 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                throw new ExecutionFailException("Eror: improper ComparatorBE usage");
            }

#line 103 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(d[0L], dmax[0L]), target));
#line hidden
            {
#line 104 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var dmax_tmp = Allocate.Apply();
#line 105 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((dmax[0L], dmax_tmp));
#line 106 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                AdderBE.Adjoint.Apply((dmax?.Copy(), d?.Copy()));
#line 107 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line 108 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line 109 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                AdderBE.Apply((dmax?.Copy(), d?.Copy()));
#line 110 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((dmax[0L], dmax_tmp));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (d,dmax,target) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper ComparatorBE usage");
            }

#line hidden
            {
#line hidden
                var dmax_tmp = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((dmax[0L], dmax_tmp));
#line hidden
                AdderBE.Adjoint.Apply((dmax?.Copy(), d?.Copy()));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target));
#line hidden
                AdderBE.Adjoint.Adjoint.Apply((dmax?.Copy(), d?.Copy()));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((dmax[0L], dmax_tmp));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((new QArray<Qubit>(d[0L], dmax[0L]), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(d,dmax,target)) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper ComparatorBE usage");
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax[0L]), target)));
#line hidden
            {
#line hidden
                var dmax_tmp = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                AdderBE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                AdderBE.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,QArray<Qubit>,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(d,dmax,target)) = __in__;
#line hidden
            var N = d.Length;
#line hidden
            var P = dmax.Length;
#line hidden
            if ((N != P))
            {
#line hidden
                throw new ExecutionFailException("Eror: improper ComparatorBE usage");
            }

#line hidden
            {
#line hidden
                var dmax_tmp = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                AdderBE.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, true, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax_tmp, dmax[0L]), target)));
#line hidden
                AdderBE.Adjoint.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax?.Copy(), d?.Copy())));
#line hidden
                MicrosoftQuantumPrimitiveCNOT.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (dmax[0L], dmax_tmp)));
#line hidden
                Release.Apply(dmax_tmp);
            }

#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumPrimitiveX)).Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Qubit>(d[0L], dmax[0L]), target)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.AdderBE = this.Factory.Get<IUnitary<(QArray<Qubit>,QArray<Qubit>)>>(typeof(AdderBE));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> d, QArray<Qubit> dmax, Qubit target)
        {
            return __m__.Run<ComparatorBE, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((d, dmax, target));
        }
    }

    public class Rzk : Unitary<(Qubit,Double)>, ICallable
    {
        public Rzk(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Rzk";
        String ICallable.FullName => "Quantum.QuantumBNN.Rzk";
        protected IUnitary<(QArray<Double>,Microsoft.Quantum.Canon.BigEndian)> MicrosoftQuantumCanonApplyDiagonalUnitary
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Double> MicrosoftQuantumExtensionsMathPowD
        {
            get;
            set;
        }

        public override Func<(Qubit,Double), QVoid> Body => (__in__) =>
        {
            var (q,k) = __in__;
#line 120 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyDiagonalUnitary.Apply((new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q})));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (q,k) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyDiagonalUnitary.Adjoint.Apply((new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q})));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Double)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(q,k)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyDiagonalUnitary.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q}))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(Qubit,Double)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(q,k)) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyDiagonalUnitary.Adjoint.Controlled.Apply((__controlQubits__?.Copy(), (new QArray<Double>(0D, ((2D * MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance)) / MicrosoftQuantumExtensionsMathPowD.Apply((2D, k)))), new Microsoft.Quantum.Canon.BigEndian(new QArray<Qubit>()
            {q}))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyDiagonalUnitary = this.Factory.Get<IUnitary<(QArray<Double>,Microsoft.Quantum.Canon.BigEndian)>>(typeof(Microsoft.Quantum.Canon.ApplyDiagonalUnitary));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathPowD = this.Factory.Get<ICallable<(Double,Double), Double>>(typeof(Microsoft.Quantum.Extensions.Math.PowD));
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double k)
        {
            return __m__.Run<Rzk, (Qubit,Double), QVoid>((q, k));
        }
    }

    public class BoolBitArrayLE : Function<(Int64,Int64), QArray<Boolean>>, ICallable
    {
        public BoolBitArrayLE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "BoolBitArrayLE";
        String ICallable.FullName => "Quantum.QuantumBNN.BoolBitArrayLE";
        protected ICallable<QVoid, Double> MicrosoftQuantumCanonLogOf2
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathFloor
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathLog
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Boolean>> Body => (__in__) =>
        {
            var (num,num_bits) = __in__;
#line 132 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var curr_num = num;
#line 133 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var bool_arr = new QArray<Boolean>(num_bits);
#line 135 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            if ((curr_num == 0L))
            {
#line 136 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                return bool_arr;
            }

#line 139 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            while (true)
            {
#line 140 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var ind = MicrosoftQuantumExtensionsMathFloor.Apply((MicrosoftQuantumExtensionsMathLog.Apply(MicrosoftQuantumExtensionsConvertToDouble.Apply(curr_num)) / MicrosoftQuantumCanonLogOf2.Apply(QVoid.Instance)));
#line 141 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                bool_arr[ind] = true;
#line 142 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                curr_num = (curr_num - 2L.Pow(ind));
                if ((curr_num == 0L))
                {
                    break;
                }
                else
                {
                }
            }

#line 147 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            return bool_arr;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonLogOf2 = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Canon.LogOf2));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathFloor = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Floor));
            this.MicrosoftQuantumExtensionsMathLog = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Log));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, Int64 num, Int64 num_bits)
        {
            return __m__.Run<BoolBitArrayLE, (Int64,Int64), QArray<Boolean>>((num, num_bits));
        }
    }

    public class FlipIfSame : Adjointable<(QArray<Qubit>,Qubit)>, ICallable
    {
        public FlipIfSame(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "FlipIfSame";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfSame";
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
            var (register,target) = __in__;
#line 156 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((register?.Copy(), target));
#line 158 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register?.Copy()));
#line 159 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply((register?.Copy(), target));
#line 160 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (register,target) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((register?.Copy(), target));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply((register?.Copy(), target));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, Qubit target)
        {
            return __m__.Run<FlipIfSame, (QArray<Qubit>,Qubit), QVoid>((register, target));
        }
    }

    public class FlipIfSame2 : Adjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public FlipIfSame2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "FlipIfSame2";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfSame2";
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

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (register1,register2,target) = __in__;
#line 172 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply(((register1 + register2), target));
#line 174 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line 175 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply(((register1 + register2), target));
#line 176 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line 178 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line 179 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply(((register1 + register2), target));
#line 180 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line 182 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line 183 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line 184 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumPrimitiveX.Controlled.Apply(((register1 + register2), target));
#line 185 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line 186 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (register1,register2,target) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply(((register1 + register2), target));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply(((register1 + register2), target));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register2?.Copy()));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply(((register1 + register2), target));
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumPrimitiveX, register1?.Copy()));
#line hidden
            MicrosoftQuantumPrimitiveX.Controlled.Adjoint.Apply(((register1 + register2), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register1, QArray<Qubit> register2, Qubit target)
        {
            return __m__.Run<FlipIfSame2, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((register1, register2, target));
        }
    }

    public class MajorityProductOnes : Adjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>, ICallable
    {
        public MajorityProductOnes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "MajorityProductOnes";
        String ICallable.FullName => "Quantum.QuantumBNN.MajorityProductOnes";
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

        protected IAdjointable<(QArray<Qubit>,Qubit,Int64)> FlipIfAtLeastRecursive
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit,Int64)> FlipIfAtleast
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit)> FlipIfSame
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> FlipIfSame2
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (weights,xs,target) = __in__;
#line 201 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var N = weights.Length;
#line 202 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            if ((N == 1L))
            {
#line 203 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                FlipIfSame.Apply((new QArray<Qubit>(weights[0L], xs[0L]), target));
            }
            else if ((N <= 3L))
            {
#line 206 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 207 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    foreach (var j in new Range((i + 1L), (N - 1L)))
#line hidden
                    {
#line 208 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        FlipIfSame2.Apply((new QArray<Qubit>(weights[i], xs[i]), new QArray<Qubit>(weights[j], xs[j]), target));
                    }
                }
            }
            else
            {
#line hidden
                {
#line 213 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    var y = Allocate.Apply(N);
#line 214 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    var min_N = ((N / 2L) + 1L);
#line 215 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 216 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        FlipIfSame.Apply((new QArray<Qubit>(weights[i], xs[i]), y[i]));
                    }

#line 219 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    var optmizedForNumQubits = true;
#line 220 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    if (optmizedForNumQubits)
                    {
#line 221 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        FlipIfAtLeastRecursive.Apply((y?.Copy(), target, min_N));
                    }
                    else
                    {
#line 223 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        FlipIfAtleast.Apply((y?.Copy(), target, min_N));
                    }

#line 230 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 231 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                        FlipIfSame.Apply((new QArray<Qubit>(weights[i], xs[i]), y[i]));
                    }

#line hidden
                    Release.Apply(y);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (weights,xs,target) = __in__;
#line hidden
            var N = weights.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                FlipIfSame.Adjoint.Apply((new QArray<Qubit>(weights[0L], xs[0L]), target));
            }
            else if ((N <= 3L))
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    foreach (var j in RangeReverse.Apply(new Range((i + 1L), (N - 1L))))
#line hidden
                    {
#line hidden
                        FlipIfSame2.Adjoint.Apply((new QArray<Qubit>(weights[i], xs[i]), new QArray<Qubit>(weights[j], xs[j]), target));
                    }
                }
            }
            else
            {
#line hidden
                {
#line hidden
                    var y = Allocate.Apply(N);
#line hidden
                    var min_N = ((N / 2L) + 1L);
#line hidden
                    var optmizedForNumQubits = true;
#line hidden
                    foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                    {
#line hidden
                        FlipIfSame.Adjoint.Apply((new QArray<Qubit>(weights[i], xs[i]), y[i]));
                    }

#line hidden
                    if (optmizedForNumQubits)
                    {
#line hidden
                        FlipIfAtLeastRecursive.Adjoint.Apply((y?.Copy(), target, min_N));
                    }
                    else
                    {
#line hidden
                        FlipIfAtleast.Adjoint.Apply((y?.Copy(), target, min_N));
                    }

#line hidden
                    foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                    {
#line hidden
                        FlipIfSame.Adjoint.Apply((new QArray<Qubit>(weights[i], xs[i]), y[i]));
                    }

#line hidden
                    Release.Apply(y);
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
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.FlipIfAtLeastRecursive = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Int64)>>(typeof(FlipIfAtLeastRecursive));
            this.FlipIfAtleast = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Int64)>>(typeof(FlipIfAtleast));
            this.FlipIfSame = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(FlipIfSame));
            this.FlipIfSame2 = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(FlipIfSame2));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> weights, QArray<Qubit> xs, Qubit target)
        {
            return __m__.Run<MajorityProductOnes, (QArray<Qubit>,QArray<Qubit>,Qubit), QVoid>((weights, xs, target));
        }
    }

    public class BNNMarkingOracleWithDesiredAccuracy : Adjointable<(QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit)>, ICallable
    {
        public BNNMarkingOracleWithDesiredAccuracy(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item6)?.Qubits);
        }

        String ICallable.Name => "BNNMarkingOracleWithDesiredAccuracy";
        String ICallable.FullName => "Quantum.QuantumBNN.BNNMarkingOracleWithDesiredAccuracy";
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

        protected ICallable<Int64, Double> MicrosoftQuantumExtensionsConvertToDouble
        {
            get;
            set;
        }

        protected ICallable<Double, Int64> MicrosoftQuantumExtensionsMathCeiling
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

        protected IAdjointable<(QArray<Qubit>,Qubit,Int64)> FlipIfAtLeastRecursive
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,Qubit,Int64)> FlipIfAtleast
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit)> Forward_IntData
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit), QVoid> Body => (__in__) =>
        {
            var (weights,accuracy,allLayers,input,labels,target) = __in__;
#line 249 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            var N = input.Length;
#line hidden
            {
#line 251 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var correctly_predicted = Allocate.Apply(N);
#line 253 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 254 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    Forward_IntData.Apply((weights?.Copy(), allLayers?.Copy(), input[i], labels[i], correctly_predicted[i]));
                }

#line 257 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var min_N = MicrosoftQuantumExtensionsMathCeiling.Apply((MicrosoftQuantumExtensionsConvertToDouble.Apply(N) * accuracy));
#line 261 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var optmizedForNumQubits = true;
#line 262 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                if (optmizedForNumQubits)
                {
#line 263 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    FlipIfAtLeastRecursive.Apply((correctly_predicted?.Copy(), target, min_N));
                }
                else
                {
#line 265 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    FlipIfAtleast.Apply((correctly_predicted?.Copy(), target, min_N));
                }

#line 268 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                {
#line 269 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    Forward_IntData.Adjoint.Apply((weights?.Copy(), allLayers?.Copy(), input[i], labels[i], correctly_predicted[i]));
                }

#line hidden
                Release.Apply(correctly_predicted);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (weights,accuracy,allLayers,input,labels,target) = __in__;
#line hidden
            var N = input.Length;
#line hidden
            {
#line hidden
                var correctly_predicted = Allocate.Apply(N);
#line hidden
                var min_N = MicrosoftQuantumExtensionsMathCeiling.Apply((MicrosoftQuantumExtensionsConvertToDouble.Apply(N) * accuracy));
#line hidden
                var optmizedForNumQubits = true;
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    Forward_IntData.Adjoint.Adjoint.Apply((weights?.Copy(), allLayers?.Copy(), input[i], labels[i], correctly_predicted[i]));
                }

#line hidden
                if (optmizedForNumQubits)
                {
#line hidden
                    FlipIfAtLeastRecursive.Adjoint.Apply((correctly_predicted?.Copy(), target, min_N));
                }
                else
                {
#line hidden
                    FlipIfAtleast.Adjoint.Apply((correctly_predicted?.Copy(), target, min_N));
                }

#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                {
#line hidden
                    Forward_IntData.Adjoint.Apply((weights?.Copy(), allLayers?.Copy(), input[i], labels[i], correctly_predicted[i]));
                }

#line hidden
                Release.Apply(correctly_predicted);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathCeiling = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Ceiling));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.FlipIfAtLeastRecursive = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Int64)>>(typeof(FlipIfAtLeastRecursive));
            this.FlipIfAtleast = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit,Int64)>>(typeof(FlipIfAtleast));
            this.Forward_IntData = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit)>>(typeof(Forward_IntData));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> weights, Double accuracy, QArray<Int64> allLayers, QArray<QArray<Int64>> input, QArray<Int64> labels, Qubit target)
        {
            return __m__.Run<BNNMarkingOracleWithDesiredAccuracy, (QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit), QVoid>((weights, accuracy, allLayers, input, labels, target));
        }
    }

    public class FlipIfAtLeastRecursive : Adjointable<(QArray<Qubit>,Qubit,Int64)>, ICallable
    {
        public FlipIfAtLeastRecursive(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "FlipIfAtLeastRecursive";
        String ICallable.FullName => "Quantum.QuantumBNN.FlipIfAtLeastRecursive";
        protected IAdjointable<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64)> ControlledOnBitStringWithMinTrue
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (register,target,min_N) = __in__;
#line 284 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            ControlledOnBitStringWithMinTrue.Apply((new QArray<Boolean>(0L), register?.Copy(), target, min_N));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (register,target,min_N) = __in__;
#line hidden
            ControlledOnBitStringWithMinTrue.Adjoint.Apply((new QArray<Boolean>(0L), register?.Copy(), target, min_N));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ControlledOnBitStringWithMinTrue = this.Factory.Get<IAdjointable<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64)>>(typeof(ControlledOnBitStringWithMinTrue));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> register, Qubit target, Int64 min_N)
        {
            return __m__.Run<FlipIfAtLeastRecursive, (QArray<Qubit>,Qubit,Int64), QVoid>((register, target, min_N));
        }
    }

    public class ControlledOnBitStringWithMinTrue : Adjointable<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64)>, ICallable
    {
        public ControlledOnBitStringWithMinTrue(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ControlledOnBitStringWithMinTrue";
        String ICallable.FullName => "Quantum.QuantumBNN.ControlledOnBitStringWithMinTrue";
        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64)> self
        {
            get;
            set;
        }

        public override Func<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (bool_array,register,target,minTrue) = __in__;
#line 291 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            if ((bool_array.Length == register.Length))
            {
#line 292 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                if ((minTrue < 1L))
                {
#line 293 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                    MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bool_array?.Copy(), MicrosoftQuantumPrimitiveX)).Apply((register?.Copy(), target));
                }
            }
            else
            {
#line 296 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                self.Apply(((bool_array + new QArray<Boolean>()
                {true}), register?.Copy(), target, (minTrue - 1L)));
#line 297 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                self.Apply(((bool_array + new QArray<Boolean>()
                {false}), register?.Copy(), target, minTrue));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Boolean>,QArray<Qubit>,Qubit,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (bool_array,register,target,minTrue) = __in__;
#line hidden
            if ((bool_array.Length == register.Length))
            {
#line hidden
                if ((minTrue < 1L))
                {
#line hidden
                    MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bool_array?.Copy(), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((register?.Copy(), target));
                }
            }
            else
            {
#line hidden
                self.Adjoint.Apply(((bool_array + new QArray<Boolean>()
                {false}), register?.Copy(), target, minTrue));
#line hidden
                self.Adjoint.Apply(((bool_array + new QArray<Boolean>()
                {true}), register?.Copy(), target, (minTrue - 1L)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.self = this;
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Boolean> bool_array, QArray<Qubit> register, Qubit target, Int64 minTrue)
        {
            return __m__.Run<ControlledOnBitStringWithMinTrue, (QArray<Boolean>,QArray<Qubit>,Qubit,Int64), QVoid>((bool_array, register, target, minTrue));
        }
    }

    public class OracleConverter : Function<IAdjointable, IAdjointable>, ICallable
    {
        public OracleConverter(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "OracleConverter";
        String ICallable.FullName => "Quantum.QuantumBNN.OracleConverter";
        protected IAdjointable<(IAdjointable,QArray<Qubit>)> OracleConverterImpl
        {
            get;
            set;
        }

        public override Func<IAdjointable, IAdjointable> Body => (__in__) =>
        {
            var markingOracle = __in__;
#line 308 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            return OracleConverterImpl.Partial(new Func<QArray<Qubit>, (IAdjointable,QArray<Qubit>)>((__arg1__) => (markingOracle, __arg1__)));
        }

        ;
        public override void Init()
        {
            this.OracleConverterImpl = this.Factory.Get<IAdjointable<(IAdjointable,QArray<Qubit>)>>(typeof(OracleConverterImpl));
        }

        public override IApplyData __dataIn(IAdjointable data) => new QTuple<IAdjointable>(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable markingOracle)
        {
            return __m__.Run<OracleConverter, IAdjointable, IAdjointable>(markingOracle);
        }
    }

    public class OracleConverterImpl : Adjointable<(IAdjointable,QArray<Qubit>)>, ICallable
    {
        public OracleConverterImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,QArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "OracleConverterImpl";
        String ICallable.FullName => "Quantum.QuantumBNN.OracleConverterImpl";
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(IAdjointable,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markingOracle,register) = __in__;
#line hidden
            {
#line 313 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                var target = Allocate.Apply();
#line 315 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
#line 316 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveH.Apply(target);
#line 320 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                markingOracle.Apply((register?.Copy(), target));
#line 323 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveH.Apply(target);
#line 324 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
                MicrosoftQuantumPrimitiveX.Apply(target);
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markingOracle,register) = __in__;
#line hidden
            {
#line hidden
                var target = Allocate.Apply();
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(target);
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(target);
#line hidden
                markingOracle.Adjoint.Apply((register?.Copy(), target));
#line hidden
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(target);
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(target);
#line hidden
                Release.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((IAdjointable,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable markingOracle, QArray<Qubit> register)
        {
            return __m__.Run<OracleConverterImpl, (IAdjointable,QArray<Qubit>), QVoid>((markingOracle, register));
        }
    }

    public class Oracle_ArbitraryPattern : Adjointable<(QArray<Qubit>,Qubit,QArray<Boolean>)>, ICallable
    {
        public Oracle_ArbitraryPattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,QArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ArbitraryPattern";
        String ICallable.FullName => "Quantum.QuantumBNN.Oracle_ArbitraryPattern";
        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,QArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target,pattern) = __in__;
#line 332 "/Users/divye/Documents/projects/QuantumBNN/Oracles.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((pattern?.Copy(), MicrosoftQuantumPrimitiveX)).Apply((queryRegister?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,Qubit,QArray<Boolean>), QVoid> AdjointBody => (__in__) =>
        {
            var (queryRegister,target,pattern) = __in__;
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((pattern?.Copy(), MicrosoftQuantumPrimitiveX)).Adjoint.Apply((queryRegister?.Copy(), target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> queryRegister, Qubit target, QArray<Boolean> pattern)
        {
            return __m__.Run<Oracle_ArbitraryPattern, (QArray<Qubit>,Qubit,QArray<Boolean>), QVoid>((queryRegister, target, pattern));
        }
    }
}