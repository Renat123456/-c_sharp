// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int [,] Reform(int[,] arr)
{
    int min = arr[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                row = i;
                column = j;
            }
        }
    }

    Console.WriteLine($"Минимум -> {min}");
    Console.WriteLine();

    int row2 = 0;
    int column2 = 0;
    int[,] arr2 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != row)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {                
                if (j != column)
                {
                    arr2[row2, column2] = arr[i, j];
                    column2++;
                }
            }            
            row2++;
            column2 = 0;
        }
    }
    return arr2;
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
arr = Reform(arr);
PrintArr(arr);