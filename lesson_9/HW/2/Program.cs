// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.WriteLine($"Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите число N");
int n = int.Parse(Console.ReadLine()!);

int Sum(int M, int N)
{
    int sum = 0;
    if (N < M)
    {        
        return sum;
    }    
    return Sum(M, N - 1) + (sum += N);
}
Console.WriteLine(Sum(m, n));