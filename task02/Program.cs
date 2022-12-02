Console.WriteLine("Введите два целых числа");

int a, b;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"{a}, больше {b}");
}
else Console.WriteLine($"{b}, больше {a}");