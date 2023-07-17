// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void Multiplication(int[,] arr, int[,] arr2)
{
    if (arr.GetLength(0) != arr2.GetLength(1))
    {
        Console.WriteLine("Умножить матрицы нельзя. Количество строк первой матрицы должно равняться количеству столбцов второй матрицы");
    }
    else
    {
        int[,] multiArr = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(0); k++)
                {
                    multiArr[i, j] = multiArr[i, j] + arr[i, k] * arr2[k, j];
                }
            }
        }
        Console.WriteLine("Произведение матриц:");
        PrintArr(multiArr);
    }
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
int[,] arr2 = new int[row, column];
FillArr(arr, A, B);
PrintArr(arr);
FillArr(arr2, A, B);
PrintArr(arr2);
Multiplication(arr, arr2);