﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("введите x1 ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y1 ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z1 ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите x2 ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y2 ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z2 ");
int z2 = int.Parse(Console.ReadLine());
double s = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
//double s = {s:f4};
Console.WriteLine($"s = {s:f2} ");
