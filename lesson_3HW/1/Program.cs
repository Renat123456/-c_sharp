// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void palindrom (int a)
{
    int a1 = a / 10000;
    int a2 = a / 1000 % 10;
    int a4 = a / 10 % 10;
    int a5 = a % 10;

    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine ($"{a} -> палиндром");
    }
    else
    {
        Console.WriteLine ($"{a} -> не палиндром");
    }
}

Console.WriteLine ("Введите пятизначное число");
int p = int.Parse(Console.ReadLine()!);
palindrom(p);