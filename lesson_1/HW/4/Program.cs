// задача 8
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

int count = 2;
while (count <= a)
{
    Console.Write(count);
    count = count + 2;
}