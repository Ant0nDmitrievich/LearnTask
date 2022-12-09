// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
Console.WriteLine("Введите натуральное число -> ");
int a = Convert.ToInt32(Console.ReadLine());

void Triple(int a)
{
    int num = 1;
    while (num <= a)
    {
        int cube =num*num*num;
        Console.Write($"{num} ");
        Console.WriteLine(cube);
        num ++;
    }
}
if (a > 0)
Triple(a);
else Console.WriteLine("Число не является натуральным");