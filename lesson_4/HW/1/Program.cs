// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Stepen(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

string? AA = "";
string? BB = "";

while (AA != "0" && BB != "0")
{
    Console.WriteLine("Введите число");
    AA = Console.ReadLine();
    Console.WriteLine("Введите степень");
    BB = Console.ReadLine();
    if (!string.IsNullOrEmpty(AA) && !string.IsNullOrEmpty(BB))
    {
        int A = int.Parse(AA);
        int B = int.Parse(BB);
        Stepen(A, B);
    }
}