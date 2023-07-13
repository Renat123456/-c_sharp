// Задача 1: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PositiveN(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    Console.WriteLine($"Чисел больше нуля -> {count}");
}

void Fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число");
        int number = int.Parse(Console.ReadLine()!);
        arr[i] = number;
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

Console.WriteLine("Введите колличество чисел");
int quantity = int.Parse(Console.ReadLine()!);

int[] arr = new int[quantity];
Fill(arr);
PrintArr(arr);
PositiveN(arr);
