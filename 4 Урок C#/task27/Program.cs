// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int SumDigit (int n)
{
    int y = 0;
    int sum1 = 0;
    int sum2 = 0;
    while (n != 0)
    {
        y = n % 10;
        n = n / 10;
        sum1 = y;
        sum2 = sum2 + sum1;
    }
    return sum2;
}
int sumdigit = SumDigit (num);
Console.WriteLine($"{num} -> {sumdigit}");
// int NumDigit(int n)
// {
//     int digit = 0;
//     while (n != 0)
//     {
//         n = n / 10;
//         digit++;
//     }
//     return digit == 0 ? 1 : digit;
// }
// int result = NumDigit(num);
// Console.WriteLine($"{num} -> {result}");