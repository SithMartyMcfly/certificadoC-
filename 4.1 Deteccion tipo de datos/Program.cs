Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MinValue}");
Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte: {byte.MinValue} to {sbyte.MinValue}");
Console.WriteLine($"ushort: {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint: {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float: {float.MinValue} to {float.MinValue}");
Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

Console.WriteLine("");
Console.WriteLine("");
int[] data;
data = new int[3];

string shortendString = "Hello world";
Console.WriteLine(shortendString);

Console.WriteLine("*******");
int val_A = 2;
int val_B = val_A;
val_B = 5;
Console.WriteLine("--Value types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");
Console.WriteLine("*******");
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;
Console.WriteLine("--Reference types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");


