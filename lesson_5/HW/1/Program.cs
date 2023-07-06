// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Quantity(int[] arr)
{
    int count = 0;  
    for (int i = 0; i < arr.Length; i++)
    {
        int a = arr[i] % 2;
        if (a == 0) count += 1;        
    }
    Console.WriteLine($"Количество чётных чисел в массиве -> {count}");
}

void Fill(int[] arr, int a, int b)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b + 1);
    }
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();     
}

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало периода");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец периода");
int B = int.Parse(Console.ReadLine()!);

int [] arr = new int[size];
Fill(arr, A, B);
PrintArr(arr);
Quantity(arr);