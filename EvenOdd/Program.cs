// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);

if ((x % 2) == 0)
{
Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
