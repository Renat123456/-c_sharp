// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend (int a)
{
    if (a < 6 && a > 0)
    {
        Console.WriteLine ("Нет");
        return;
    }
    if (a > 5 && a < 8)
    {
        Console.WriteLine ("Да");
        return;
    }
    Console.WriteLine ("День недели не существует");    
}

int day = int.Parse (Console.ReadLine ()!);
Weekend(day);