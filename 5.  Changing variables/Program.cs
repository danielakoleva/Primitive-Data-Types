int a = 5;
int b = 10;
int c;
Console.WriteLine($"a = {a}"); // 5
Console.WriteLine($"b = {b}"); // 10
c = a;
a = b;
b = c;
Console.WriteLine($"a = {a}"); // 10
Console.WriteLine($"b = {b}"); // 5