// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Stepen (int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int B = int.Parse(Console.ReadLine()!);

Stepen (A, B);