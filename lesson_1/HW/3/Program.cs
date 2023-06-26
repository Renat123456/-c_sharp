// задача 6
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

int b = a % 2;

if (b == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}