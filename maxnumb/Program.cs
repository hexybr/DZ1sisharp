//программa, которая принимает на вход три числа и выдаёт максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число x");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число y");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число z");
int z = int.Parse(Console.ReadLine()!);

int max = x;

if (x > max) max = x;
if (y > max) max = y;
if (z > max) max = z;

Console.WriteLine("max = "+max);