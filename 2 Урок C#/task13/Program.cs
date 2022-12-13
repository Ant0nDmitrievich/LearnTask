// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int ThirdDigit (int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
if (n < 0) n = -n;
if (n > 99)
{
    int result =ThirdDigit(n);
    Console.WriteLine($"{n} -> {result}");
}
else
{
    Console.WriteLine($"{n} -> Третьей цифры нет");
}
