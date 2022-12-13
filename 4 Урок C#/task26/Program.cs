// Задача 26:
// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int NumDigit(int n)
{
    int digit = 0;
    while (n != 0)
    {
        n = n / 10;
        digit++;
    }
    return digit;
}
int result = NumDigit(num);
Console.WriteLine($"{num} -> {result}");