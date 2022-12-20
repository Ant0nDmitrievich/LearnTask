// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество чисел: ");
Console.Write("M: ");
int m = Convert.ToInt32(Console.ReadLine());

int EnterNum(int num)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}
int PositiveNum(int num)
{
    int sum = 0;
    for (int i = 0; i < num; i++)
        if (num > 0) sum++;
    return sum;
}
int enternum = EnterNum(m);
int positiveNum = PositiveNum(m);
Console.WriteLine($"{positiveNum}");