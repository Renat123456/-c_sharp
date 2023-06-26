// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Number3 (int a)
{
    int b = a / 100;
    if (b == 0)
    {
        Console.WriteLine ($"Третьей цифры нет");
        return;
    }
    b = a % 1000;
    int c = b / 100;
    Console.WriteLine ($"Третье число {c}");
}
int number = int.Parse(Console.ReadLine()!);
Number3(number);