// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.Write($"[");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3}, ");
        else Console.Write($"{arr[i, j], 3}");
    }
    Console.Write($"]");
    Console.WriteLine();
}
Console.WriteLine("");
// Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    double res = sum / arr.GetLength(0);
    double res1 = Math.Round(res, 1, MidpointRounding.ToZero);
    Console.Write($"{res1, 4} ");
}