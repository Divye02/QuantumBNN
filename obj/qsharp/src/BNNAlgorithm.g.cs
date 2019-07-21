#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"TrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_points\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"accuracy\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num_correct_weights\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":118}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Double\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"TrainModel\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"TrainModel_ForNumIter\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_points\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"labels\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"allLayers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":79}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num_weights\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":88},\"Item2\":{\"Line\":1,\"Column\":99}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"accuracy\"]},\"Type\":{\"Case\":\"Double\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":106},\"Item2\":{\"Line\":1,\"Column\":114}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"num_iter\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":124},\"Item2\":{\"Line\":1,\"Column\":132}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"TrainModel_ForNumIter\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Forward_IntData\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"allLayers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_point_int\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":77}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"label\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":91}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":104}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Forward_IntData\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":57,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Forward_IntData\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":74,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Forward\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":77,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"allLayers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_point\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"actual_label\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":88}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"current_layer_i\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":97},\"Item2\":{\"Line\":1,\"Column\":112}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"prediction\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":119},\"Item2\":{\"Line\":1,\"Column\":129}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_train_mode\"]},\"Type\":{\"Case\":\"Bool\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":138},\"Item2\":{\"Line\":1,\"Column\":151}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Forward\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":78,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Forward\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":106,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"WeightsLayerI\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":111,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"layer_i\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"WeightsLayerI\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":111,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ForwardSingleLayer\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"layer\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":84}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[{\"Case\":\"Adjoint\"}]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ForwardSingleLayer\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":119,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"ForwardSingleLayer\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":127,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Predict\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_point_int\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights_int\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":75}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"Predict\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"PredictAll\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"data_points_int\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hidden_layers\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"weights_int\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.QuantumBNN\",\"Name\":\"PredictAll\"},\"SourceFile\":\"/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.QuantumBNN
{
    public class TrainModel : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>>, ICallable
    {
        public TrainModel(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TrainModel";
        String ICallable.FullName => "Quantum.QuantumBNN.TrainModel";
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

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get;
            set;
        }

        protected ICallable<(QArray<Int64>,QArray<Int64>), Double> CalculateAccuracy
        {
            get;
            set;
        }

        protected ICallable<QArray<Int64>, Int64> ComputeNumWeights
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>> PredictAll
        {
            get;
            set;
        }

        protected ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64), QArray<Int64>> TrainModel_ForNumIter
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>> Body => (__in__) =>
        {
            var (data_points,labels,hidden_layers,accuracy,num_correct_weights) = __in__;
#line 13 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            MicrosoftQuantumCanonAssertIntEqual.Apply((data_points.Length, labels.Length, "The number of data points and labels given are not equal"));
#line 15 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var input_dim = new QArray<Int64>()
            {data_points[0L].Length};
#line 16 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var output_dim = new QArray<Int64>()
            {1L};
#line 17 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var allLayers = ((input_dim + hidden_layers) + output_dim);
#line 18 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var num_weights = ComputeNumWeights.Apply(allLayers);
#line 20 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            if ((num_correct_weights != -(1L)))
            {
#line 21 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                return TrainModel_ForNumIter.Apply((data_points?.Copy(), labels?.Copy(), allLayers?.Copy(), num_weights, accuracy, num_correct_weights));
            }

#line 24 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var num_weight_states = MicrosoftQuantumExtensionsConvertToDouble.Apply(2L.Pow(num_weights));
#line 25 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var max_num_iter = MicrosoftQuantumExtensionsMathFloor.Apply(((MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance) / 4D) * MicrosoftQuantumExtensionsMathSqrt.Apply(num_weight_states)));
#line 26 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var max_tries_per_iter = 3L;
#line 28 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            foreach (var num_iter in new Range(1L, max_num_iter))
#line hidden
            {
#line 29 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                foreach (var i in new Range(1L, max_tries_per_iter))
#line hidden
                {
#line 30 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    var weights = TrainModel_ForNumIter.Apply((data_points?.Copy(), labels?.Copy(), allLayers?.Copy(), num_weights, accuracy, num_iter));
#line 31 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    var predictions = PredictAll.Apply((data_points?.Copy(), hidden_layers?.Copy(), weights?.Copy()));
#line 32 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    if ((CalculateAccuracy.Apply((labels?.Copy(), predictions?.Copy())) >= accuracy))
                    {
#line 33 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                        return weights;
                    }
                }
            }

#line 38 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            return new QArray<Int64>(0L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonAssertIntEqual = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Canon.AssertIntEqual));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumExtensionsConvertToDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Extensions.Convert.ToDouble));
            this.MicrosoftQuantumExtensionsMathFloor = this.Factory.Get<ICallable<Double, Int64>>(typeof(Microsoft.Quantum.Extensions.Math.Floor));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.MicrosoftQuantumExtensionsMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Extensions.Math.Sqrt));
            this.CalculateAccuracy = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>), Double>>(typeof(CalculateAccuracy));
            this.ComputeNumWeights = this.Factory.Get<ICallable<QArray<Int64>, Int64>>(typeof(ComputeNumWeights));
            this.PredictAll = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>>>(typeof(PredictAll));
            this.TrainModel_ForNumIter = this.Factory.Get<ICallable<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64), QArray<Int64>>>(typeof(TrainModel_ForNumIter));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<QArray<Int64>> data_points, QArray<Int64> labels, QArray<Int64> hidden_layers, Double accuracy, Int64 num_correct_weights)
        {
            return __m__.Run<TrainModel, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Double,Int64), QArray<Int64>>((data_points, labels, hidden_layers, accuracy, num_correct_weights));
        }
    }

    public class TrainModel_ForNumIter : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64), QArray<Int64>>, ICallable
    {
        public TrainModel_ForNumIter(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TrainModel_ForNumIter";
        String ICallable.FullName => "Quantum.QuantumBNN.TrainModel_ForNumIter";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
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

        protected IAdjointable<(QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit)> BNNMarkingOracleWithDesiredAccuracy
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,IAdjointable,Int64)> GroversSearch
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Int64>> ReadQubitArray
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64), QArray<Int64>> Body => (__in__) =>
        {
            var (data_points,labels,allLayers,num_weights,accuracy,num_iter) = __in__;
#line 44 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var result_weights = new QArray<Int64>(0L);
#line hidden
            {
#line 45 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                var weights = Allocate.Apply(num_weights);
#line 47 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumPrimitiveH, weights?.Copy()));
#line 49 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                GroversSearch.Apply((weights?.Copy(), BNNMarkingOracleWithDesiredAccuracy.Partial(new Func<(QArray<Qubit>,Qubit), (QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit)>((__arg1__) => (__arg1__.Item1, accuracy, allLayers?.Copy(), data_points?.Copy(), labels?.Copy(), __arg1__.Item2))), num_iter));
#line 50 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                result_weights = ReadQubitArray.Apply(weights?.Copy());
#line 52 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                ResetAll.Apply(weights?.Copy());
#line hidden
                Release.Apply(weights);
            }

#line 54 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            return result_weights;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.BNNMarkingOracleWithDesiredAccuracy = this.Factory.Get<IAdjointable<(QArray<Qubit>,Double,QArray<Int64>,QArray<QArray<Int64>>,QArray<Int64>,Qubit)>>(typeof(BNNMarkingOracleWithDesiredAccuracy));
            this.GroversSearch = this.Factory.Get<IAdjointable<(QArray<Qubit>,IAdjointable,Int64)>>(typeof(GroversSearch));
            this.ReadQubitArray = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Int64>>>(typeof(ReadQubitArray));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<QArray<Int64>> data_points, QArray<Int64> labels, QArray<Int64> allLayers, Int64 num_weights, Double accuracy, Int64 num_iter)
        {
            return __m__.Run<TrainModel_ForNumIter, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>,Int64,Double,Int64), QArray<Int64>>((data_points, labels, allLayers, num_weights, accuracy, num_iter));
        }
    }

    public class Forward_IntData : Adjointable<(QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit)>, ICallable
    {
        public Forward_IntData(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "Forward_IntData";
        String ICallable.FullName => "Quantum.QuantumBNN.Forward_IntData";
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

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)> Forward
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>)> PrepareQubitArray
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit), QVoid> Body => (__in__) =>
        {
            var (weights,allLayers,data_point_int,label,target) = __in__;
#line hidden
            {
#line 59 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                var (data_point_qubit,label_qubit,bias) = (Allocate.Apply(data_point_int.Length), Allocate.Apply(), Allocate.Apply());
#line 60 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                PrepareQubitArray.Apply((data_point_qubit?.Copy(), data_point_int?.Copy()));
#line 61 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                PrepareQubitArray.Apply((new QArray<Qubit>()
                {label_qubit}, new QArray<Int64>()
                {label}));
#line 62 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                MicrosoftQuantumPrimitiveX.Apply(bias);
#line 64 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                Forward.Apply((weights?.Copy(), allLayers?.Copy(), (data_point_qubit + new QArray<Qubit>()
                {bias}), label_qubit, 1L, target, true));
#line 70 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                MicrosoftQuantumPrimitiveX.Apply(bias);
#line 71 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                PrepareQubitArray.Apply((new QArray<Qubit>()
                {label_qubit}, new QArray<Int64>()
                {label}));
#line 72 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                PrepareQubitArray.Apply((data_point_qubit?.Copy(), data_point_int?.Copy()));
#line hidden
                Release.Apply(data_point_qubit);
#line hidden
                Release.Apply(label_qubit);
#line hidden
                Release.Apply(bias);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (weights,allLayers,data_point_int,label,target) = __in__;
#line hidden
            {
#line hidden
                var (data_point_qubit,label_qubit,bias) = (Allocate.Apply(data_point_int.Length), Allocate.Apply(), Allocate.Apply());
#line hidden
                PrepareQubitArray.Adjoint.Apply((data_point_qubit?.Copy(), data_point_int?.Copy()));
#line hidden
                PrepareQubitArray.Adjoint.Apply((new QArray<Qubit>()
                {label_qubit}, new QArray<Int64>()
                {label}));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(bias);
#line hidden
                Forward.Adjoint.Apply((weights?.Copy(), allLayers?.Copy(), (data_point_qubit + new QArray<Qubit>()
                {bias}), label_qubit, 1L, target, true));
#line hidden
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(bias);
#line hidden
                PrepareQubitArray.Adjoint.Apply((new QArray<Qubit>()
                {label_qubit}, new QArray<Int64>()
                {label}));
#line hidden
                PrepareQubitArray.Adjoint.Apply((data_point_qubit?.Copy(), data_point_int?.Copy()));
#line hidden
                Release.Apply(data_point_qubit);
#line hidden
                Release.Apply(label_qubit);
#line hidden
                Release.Apply(bias);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Forward = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)>>(typeof(Forward));
            this.PrepareQubitArray = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Int64>)>>(typeof(PrepareQubitArray));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> weights, QArray<Int64> allLayers, QArray<Int64> data_point_int, Int64 label, Qubit target)
        {
            return __m__.Run<Forward_IntData, (QArray<Qubit>,QArray<Int64>,QArray<Int64>,Int64,Qubit), QVoid>((weights, allLayers, data_point_int, label, target));
        }
    }

    public class Forward : Adjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)>, ICallable
    {
        public Forward(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item6)?.Qubits);
        }

        String ICallable.Name => "Forward";
        String ICallable.FullName => "Quantum.QuantumBNN.Forward";
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

        protected IAdjointable<(QArray<Qubit>,Qubit)> FlipIfSame
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)> self
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>)> ForwardSingleLayer
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Int64>,Int64), QArray<Qubit>> WeightsLayerI
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean), QVoid> Body => (__in__) =>
        {
            var (weights,allLayers,data_point,actual_label,current_layer_i,prediction,in_train_mode) = __in__;
#line 80 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            if ((current_layer_i == allLayers.Length))
            {
#line 82 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                if (in_train_mode)
                {
#line 83 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    FlipIfSame.Apply((new QArray<Qubit>(data_point[0L], actual_label), prediction));
                }
                else
                {
#line 85 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((data_point[0L], prediction));
                }
            }
            else
            {
#line 88 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                var i = current_layer_i;
#line hidden
                {
#line 89 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    var layer_out = Allocate.Apply((allLayers[i] + 1L));
#line 90 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    var weights_i = WeightsLayerI.Apply((weights?.Copy(), allLayers?.Copy(), i));
#line 93 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    MicrosoftQuantumPrimitiveX.Apply(layer_out[allLayers[i]]);
#line 94 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    ForwardSingleLayer.Apply((weights_i?.Copy(), allLayers?.Slice(new Range((i - 1L), i)), data_point?.Copy(), layer_out?.Copy()));
#line 96 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    self.Apply((weights?.Copy(), allLayers?.Copy(), layer_out?.Copy(), actual_label, (i + 1L), prediction, in_train_mode));
#line 102 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    MicrosoftQuantumPrimitiveX.Apply(layer_out[allLayers[i]]);
#line 103 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                    ForwardSingleLayer.Adjoint.Apply((weights_i?.Copy(), allLayers?.Slice(new Range((i - 1L), i)), data_point?.Copy(), layer_out?.Copy()));
#line hidden
                    Release.Apply(layer_out);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (weights,allLayers,data_point,actual_label,current_layer_i,prediction,in_train_mode) = __in__;
#line hidden
            if ((current_layer_i == allLayers.Length))
            {
#line hidden
                if (in_train_mode)
                {
#line hidden
                    FlipIfSame.Adjoint.Apply((new QArray<Qubit>(data_point[0L], actual_label), prediction));
                }
                else
                {
#line hidden
                    MicrosoftQuantumPrimitiveCNOT.Adjoint.Apply((data_point[0L], prediction));
                }
            }
            else
            {
#line hidden
                var i = current_layer_i;
#line hidden
                {
#line hidden
                    var layer_out = Allocate.Apply((allLayers[i] + 1L));
#line hidden
                    var weights_i = WeightsLayerI.Apply((weights?.Copy(), allLayers?.Copy(), i));
#line hidden
                    ForwardSingleLayer.Adjoint.Adjoint.Apply((weights_i?.Copy(), allLayers?.Slice(new Range((i - 1L), i)), data_point?.Copy(), layer_out?.Copy()));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(layer_out[allLayers[i]]);
#line hidden
                    self.Adjoint.Apply((weights?.Copy(), allLayers?.Copy(), layer_out?.Copy(), actual_label, (i + 1L), prediction, in_train_mode));
#line hidden
                    ForwardSingleLayer.Adjoint.Apply((weights_i?.Copy(), allLayers?.Slice(new Range((i - 1L), i)), data_point?.Copy(), layer_out?.Copy()));
#line hidden
                    MicrosoftQuantumPrimitiveX.Adjoint.Apply(layer_out[allLayers[i]]);
#line hidden
                    Release.Apply(layer_out);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.FlipIfSame = this.Factory.Get<IAdjointable<(QArray<Qubit>,Qubit)>>(typeof(FlipIfSame));
            this.self = this;
            this.ForwardSingleLayer = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>)>>(typeof(ForwardSingleLayer));
            this.WeightsLayerI = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Int64>,Int64), QArray<Qubit>>>(typeof(WeightsLayerI));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> weights, QArray<Int64> allLayers, QArray<Qubit> data_point, Qubit actual_label, Int64 current_layer_i, Qubit prediction, Boolean in_train_mode)
        {
            return __m__.Run<Forward, (QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean), QVoid>((weights, allLayers, data_point, actual_label, current_layer_i, prediction, in_train_mode));
        }
    }

    public class WeightsLayerI : Function<(QArray<Qubit>,QArray<Int64>,Int64), QArray<Qubit>>, ICallable
    {
        public WeightsLayerI(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "WeightsLayerI";
        String ICallable.FullName => "Quantum.QuantumBNN.WeightsLayerI";
        protected ICallable<(QArray<Int64>,Int64), Int64> GetWeightsStartPosition
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,Int64), QArray<Qubit>> Body => (__in__) =>
        {
            var (weights,layers,layer_i) = __in__;
#line 113 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var len_weights_i = ((layers[(layer_i - 1L)] * layers[layer_i]) + layers[layer_i]);
#line 114 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var pos = GetWeightsStartPosition.Apply((layers?.Copy(), layer_i));
#line 115 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            return weights?.Slice(new Range(pos, ((pos + len_weights_i) - 1L)));
        }

        ;
        public override void Init()
        {
            this.GetWeightsStartPosition = this.Factory.Get<ICallable<(QArray<Int64>,Int64), Int64>>(typeof(GetWeightsStartPosition));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Qubit> data) => data;
        public static System.Threading.Tasks.Task<QArray<Qubit>> Run(IOperationFactory __m__, QArray<Qubit> weights, QArray<Int64> layers, Int64 layer_i)
        {
            return __m__.Run<WeightsLayerI, (QArray<Qubit>,QArray<Int64>,Int64), QArray<Qubit>>((weights, layers, layer_i));
        }
    }

    public class ForwardSingleLayer : Adjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>)>, ICallable
    {
        public ForwardSingleLayer(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ForwardSingleLayer";
        String ICallable.FullName => "Quantum.QuantumBNN.ForwardSingleLayer";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)> MajorityProductOnes
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (weights,layer,input,output) = __in__;
#line 121 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            foreach (var i in new Range(0L, (layer[1L] - 1L)))
#line hidden
            {
#line 122 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                var start_w = (i * (layer[0L] + 1L));
#line 123 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                var end_w = (start_w + (layer[0L] + 1L));
#line 125 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                MajorityProductOnes.Apply((weights?.Slice(new Range(start_w, (end_w - 1L))), input?.Copy(), output[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (weights,layer,input,output) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (layer[1L] - 1L))))
#line hidden
            {
#line hidden
                var start_w = (i * (layer[0L] + 1L));
#line hidden
                var end_w = (start_w + (layer[0L] + 1L));
#line hidden
                MajorityProductOnes.Adjoint.Apply((weights?.Slice(new Range(start_w, (end_w - 1L))), input?.Copy(), output[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MajorityProductOnes = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Qubit>,Qubit)>>(typeof(MajorityProductOnes));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> weights, QArray<Int64> layer, QArray<Qubit> input, QArray<Qubit> output)
        {
            return __m__.Run<ForwardSingleLayer, (QArray<Qubit>,QArray<Int64>,QArray<Qubit>,QArray<Qubit>), QVoid>((weights, layer, input, output));
        }
    }

    public class Predict : Operation<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>, ICallable
    {
        public Predict(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Int64>,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Int64>,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Predict";
        String ICallable.FullName => "Quantum.QuantumBNN.Predict";
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

        protected ICallable<Qubit, Result> M
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

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)> Forward
        {
            get;
            set;
        }

        protected IAdjointable<(QArray<Qubit>,QArray<Int64>)> PrepareQubitArray
        {
            get;
            set;
        }

        public override Func<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64> Body => (__in__) =>
        {
            var (data_point_int,hidden_layers,weights_int) = __in__;
#line 133 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var input_dim = new QArray<Int64>()
            {data_point_int.Length};
#line 134 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var output_dim = new QArray<Int64>()
            {1L};
#line 135 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var allLayers = ((input_dim + hidden_layers) + output_dim);
#line 137 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var prediction = -(1L);
#line hidden
            {
#line 138 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                var (data_point,weights,bias,unknown_label) = (Allocate.Apply(data_point_int.Length), Allocate.Apply(weights_int.Length), Allocate.Apply(), Allocate.Apply());
#line 140 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                PrepareQubitArray.Apply((data_point?.Copy(), data_point_int?.Copy()));
#line 141 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                PrepareQubitArray.Apply((weights?.Copy(), weights_int?.Copy()));
#line 142 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                MicrosoftQuantumPrimitiveX.Apply(bias);
#line 144 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                Forward.Apply((weights?.Copy(), allLayers?.Copy(), (data_point + new QArray<Qubit>()
                {bias}), unknown_label, 1L, unknown_label, false));
#line 145 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                prediction = ((M.Apply(unknown_label) == Result.One) ? 1L : 0L);
#line 147 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                ResetAll.Apply(data_point?.Copy());
#line 148 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                ResetAll.Apply(weights?.Copy());
#line 149 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                Reset.Apply(bias);
#line 150 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                Reset.Apply(unknown_label);
#line hidden
                Release.Apply(data_point);
#line hidden
                Release.Apply(weights);
#line hidden
                Release.Apply(bias);
#line hidden
                Release.Apply(unknown_label);
            }

#line 152 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            return prediction;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.Forward = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Int64>,QArray<Qubit>,Qubit,Int64,Qubit,Boolean)>>(typeof(Forward));
            this.PrepareQubitArray = this.Factory.Get<IAdjointable<(QArray<Qubit>,QArray<Int64>)>>(typeof(PrepareQubitArray));
        }

        public override IApplyData __dataIn((QArray<Int64>,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Int64> data_point_int, QArray<Int64> hidden_layers, QArray<Int64> weights_int)
        {
            return __m__.Run<Predict, (QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>((data_point_int, hidden_layers, weights_int));
        }
    }

    public class PredictAll : Operation<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>>, ICallable
    {
        public PredictAll(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PredictAll";
        String ICallable.FullName => "Quantum.QuantumBNN.PredictAll";
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

        public override Func<(QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>> Body => (__in__) =>
        {
            var (data_points_int,hidden_layers,weights_int) = __in__;
#line 156 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var N = data_points_int.Length;
#line 157 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            var predictions = new QArray<Int64>(N);
#line 158 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 159 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
                predictions[i] = Predict.Apply((data_points_int[i], hidden_layers?.Copy(), weights_int?.Copy()));
            }

#line 161 "/Users/divye/Documents/projects/QuantumBNN/BNNAlgorithm.qs"
            return predictions;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Predict = this.Factory.Get<ICallable<(QArray<Int64>,QArray<Int64>,QArray<Int64>), Int64>>(typeof(Predict));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<QArray<Int64>> data_points_int, QArray<Int64> hidden_layers, QArray<Int64> weights_int)
        {
            return __m__.Run<PredictAll, (QArray<QArray<Int64>>,QArray<Int64>,QArray<Int64>), QArray<Int64>>((data_points_int, hidden_layers, weights_int));
        }
    }
}