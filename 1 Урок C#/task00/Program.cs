﻿// Напишите программу, которая 
// на вход принимает число и
// выдает его квадрат(число умноженное само на себя).

// Пример:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Введите целое число ");
int n = Convert.ToInt32(Console.ReadLine());

int s = n*n;

Console.WriteLine($"Квадрат числа {n} = {s}");
