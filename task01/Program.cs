Console.WriteLine("Введите два целых числа");

int a, b;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да, первое число является квадратом второго");
};
else Console.WriteLine("Нет");