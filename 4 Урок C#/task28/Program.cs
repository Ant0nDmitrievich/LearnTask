Console.WriteLine("Введите натуральное число");
int a = Convert.ToInt32(Console.ReadLine());
int Multicity (int x)
{
    int y = 1;
    for (int i = 1; i <= x; i++)
    {
        y *= i;
    }
    return y;
}
if (a > 0)
{
    int multicity = Multicity(a);
    Console.WriteLine($"Произведение чисел от 1 до {a} => {multicity}");
}
else Console.WriteLine("Данные введены не корректно");