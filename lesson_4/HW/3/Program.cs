// Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }   
}

void Fill(int[] arr, int a, int b)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b + 1);
    }
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