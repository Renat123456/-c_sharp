// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

void Sum_massive(int[,] array)
{
    int sum = 0;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("не будет ровной диагонали");
        return;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                sum = sum + array[i, j];
            }


        }
    }
    Console.Write($"{sum}");

}
