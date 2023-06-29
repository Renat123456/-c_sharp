// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Number2 (int a)
{
    int b = a % 100;
    int c = b / 10;
    Console.WriteLine ($"Второе число  {c}");
}
int number3x = int.Parse(Console.ReadLine()!);
Number2 (number3x);