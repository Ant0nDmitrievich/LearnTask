﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayDouble(int size, int min, int max) 
{

    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1 );

    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i += 1)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindMax(double[] ar) 
{
    double result = 0;
    for (int i = 1; i < ar.Length; i++)
    {
        double maximal = ar[i];
        if (maximal > ar[i - 1]);
        else maximal = ar[i - 1];
        result = maximal;
    }
    
    return result;
}
double FindMin(double[] ar) 
{
    double result = 0;
    for (int i = 1; i < ar.Length; i++)
    {
        double minimal = ar[i];
        if (minimal > ar[i - 1]) minimal = ar[i-1];

    }
    
    return result;
}
double Answer(double min, double max) 
{
    double res = max - min;
    return res;
}
Console.WriteLine("1. размер 2. мин. число 3. макс. число ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
double[] print = CreateArrayDouble(num1, num2, num3);
PrintArray(print);
double answer1 = FindMax(print);
double answer2 = FindMin(print);
double answer3 = Answer(answer1, answer2);
Console.WriteLine(answer3);