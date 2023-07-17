// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArr(double[,] arr, double a, double b)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble()*(b-a) + a;
        }        
    }
}

void PrintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i,j], 2) + " ");
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
double A = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец периода");
double B = double.Parse(Console.ReadLine()!);

double [,] arr = new double[row, column];
FillArr(arr, A, B);
PrintArr(arr);
