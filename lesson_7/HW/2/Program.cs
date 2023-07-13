// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArr(int[,] arr, int a, int b)
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
Console.WriteLine("Введите номер строки");
int R = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца");
int C = int.Parse(Console.ReadLine()!);

int [,] arr = new int[row, column];
FillArr(arr, A, B);
PrintArr(arr);

if (R <= arr.GetLength(0) && C <= arr.GetLength(1))
{
    Console.WriteLine(arr[R -1 , C - 1]);    
}
else
{
    Console.WriteLine("Такой позиции нет");    
}