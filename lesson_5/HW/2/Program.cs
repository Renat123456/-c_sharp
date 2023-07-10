// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Sum(int[] arr)
{
    int count = 0;  
    for (int i = 0; i < arr.Length; i += 2)
    {
        count += arr[i];        
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {count}");
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
Sum(arr);