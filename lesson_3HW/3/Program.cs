// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void cub (int n)
{
    int a = Math.Abs(n);
    int count = 1;
    while (count <= a)
    {
        Console.WriteLine (Math.Pow(count, 3));
        count++;
    }
}

Console.WriteLine ("Введите число N");
int n = int.Parse(Console.ReadLine()!);
cub(n);