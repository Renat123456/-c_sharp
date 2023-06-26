string a = Console.ReadLine()!;
switch (a)
{
case "1":
Console.Write("Понедельник");
break;
case "2":
Console.Write("Вторник");
break;
case "3":
Console.Write("Среда");
break;
case "4":
Console.Write("Четверг");
break;
case "5":
Console.Write("Пятница");
break;
case "6":
Console.Write("Суббота");
break;
case "7":
Console.Write("Воскресенье");
break;
default:
Console.Write("Такого дня недели нет");
break;
}

string b = Console.ReadLine();

if (b == "1")
{
    Console.WriteLine("Понедельник");
}
else if (b == "2")
{
    Console.WriteLine("Вторник");
}
else if (b == "3")
{
    Console.WriteLine("Среда");
}
else if (b == "4")
{
    Console.WriteLine("Черверг");
}
else if (b == "5")
{
    Console.WriteLine("Пятница");
}
else if (b == "6")
{
    Console.WriteLine("Суббота");
}
else if (b == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Неверные данные");
}