Console.WriteLine("Введите натуральное число");
int a = Convert.ToInt32(Console.ReadLine());
int Sum (int x)
{
    int y = 0;
    for (int i = 1; i <= x; i++)
    {
        y += i;
    }
    return y;
}
if (a > 0)
{
    int sum = Sum(a);
    Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");
}
else Console.WriteLine("Данные введены не корректно");