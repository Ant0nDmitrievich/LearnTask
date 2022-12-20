// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число, которое хотите преобразовать в двоичную систему исчисления.");
int a = Convert.ToInt32(Console.ReadLine());

string DecimalToBinary(int a)
{
    string result = string.Empty;
    while (a > 0)
    {
        result = a % 2 + result;
        a = a / 2;
    }
    return result;
}
Console.WriteLine(DecimalToBinary(a));