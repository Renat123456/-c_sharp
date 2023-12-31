﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
    Console.WriteLine($"Расстояние между точками -> {dist}");
}

Console.WriteLine ("Введите x координату первой точки");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите y координату первой точки");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите z координату первой точки");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите x координату второй точки");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите y координату второй точки");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите z координату второй точки");
int z2 = int.Parse(Console.ReadLine()!);
distance(x1, y1, z1, x2, y2, z2);