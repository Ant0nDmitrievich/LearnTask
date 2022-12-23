// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (0,5; 0,5)

Console.WriteLine("Введите четыре числа: ");
Console.Write("K1: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("K2: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
double c = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
double d = Convert.ToInt32(Console.ReadLine());

double x = (c - d) / (a - b);
double y = ((a * x) + c) / ((b * x) + d);
double res1 = Math.Round(x, 1, MidpointRounding.ToZero);
double res2 = Math.Round(y, 1, MidpointRounding.ToZero);
Console.WriteLine($"({res1}; {res2})");