// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите четыре числа: ");
Console.Write("B1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("K1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("K2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int y1 = k1 * x + b1;
int y2 = k2 * x + b2;

