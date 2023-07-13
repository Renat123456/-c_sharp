// Задача 4: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования

void CopyArr(int[,] arr, int[,] arr2)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr2[i,j] = arr[i,j];
        }        
    }
}

void Fill(int[,] arr, int a, int b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(a, b + 1);
        }        
    }
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();         
    }
    Console.WriteLine();     
}

Console.WriteLine("Введите размер строк массива");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер столбцов массива");
int column = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало периода");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец периода");
int B = int.Parse(Console.ReadLine()!);

int [,] arr = new int[row, column];
int [,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
Fill(arr, A, B);
PrintArr(arr);
CopyArr(arr, arr2);
PrintArr(arr);