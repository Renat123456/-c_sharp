// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void Difference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];      
    }
    Console.WriteLine($"Минимум -> {min}, максимум -> {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {Math.Round(max - min, 2)}");
}

void Fill(double[] arr, int a, int b)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() + new Random().Next(a, b), 2);
    }
}

void PrintArr(double[] arr)
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

double [] arr = new double[size];
Fill(arr, A, B);
PrintArr(arr);
Difference(arr);