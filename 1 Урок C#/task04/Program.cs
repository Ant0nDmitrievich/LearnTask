Console.WriteLine("Введите три целых числа");

int a, b, c;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
        if (a>c)
        {
    Console.WriteLine($"{a} самое большое число");
    }
    else Console.WriteLine($"{c} самое большое число");
}
else if (b>c)
{
    Console.WriteLine($"{b} самое большое число");
}
else Console.WriteLine($"{c} самое большое число");
