﻿/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("y = k1 * x + b1,");
Console.WriteLine("y= k2 * x + b2");

Console.WriteLine("Введите значение для b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение для k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение для b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение для k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
