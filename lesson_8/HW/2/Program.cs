// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArr(int[,] arr, int a, int b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(a, b + 1);
        }
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumMin(int[,] arr)
{
    int sum;
    int sumMin = 0;
    int row = 1;
    bool firstSum = false;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];            
        }
        if (firstSum == false)
        {
            sumMin = sum;
            firstSum = true;
        }
        else
        {
            if (sumMin > sum)
            {
                sumMin = sum;
                row = i + 1;
            }
        }
        Console.Write(sum + " ");
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {row}");
}

Console.WriteLine("Введите размер строк массива");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер столбцов массива");
int column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало периода");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец периода");
int B = int.Parse(Console.ReadLine()!);

int[,] arr = new int[row, column];
FillArr(arr, A, B);
PrintArr(arr);
SumMin(arr);