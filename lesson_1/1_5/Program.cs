int a = int.Parse(Console.ReadLine()!);
if (a > 0)
{
    int b = -a;
    while (b < a + 1)
    {
        Console.Write(b);
        b = b + 1;
    }
}
else
{
    int b = -a;
    while (b > a - 1)
    {
        Console.Write(b);
        b = b - 1;
    }
}

int x = int.Parse(Console.ReadLine()!);
int count = -x;
Console.WriteLine(count);
while (count != x)
{
    if (x > 0)
        count++;
    else
        count--;
    Console.WriteLine(count);
}
