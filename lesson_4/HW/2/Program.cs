// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sum (int number)
{
    int result = 0;
    for (int i = 0; number > 0; i++)
    {
        result = result + number % 10;
        number = number / 10;        
    }
    Console.WriteLine(result);
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Sum(number);
