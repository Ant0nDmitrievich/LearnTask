// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

Console.WriteLine("Введите 2 целых числа");
Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Exponent(int x, int z)
{
    int y = a;
    for (int i = 2; i <= z; i++)
    {
        y *= a;
    }
    return y;
}
int exponent = Exponent(a, b);
if (b == 0)
{
    Console.WriteLine($"{a}, {b} -> 1");
}
else
{
    if (b >= 0)
    {
        Console.WriteLine($"{a}, {b} -> {exponent}");
    }
    else Console.WriteLine($"Некорректно введено число степени");
}