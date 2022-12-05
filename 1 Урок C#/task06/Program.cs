Console.WriteLine("Введите число");

int a;

a = Convert.ToInt32(Console.ReadLine());

if (a / 2)
{
    Console.WriteLine($"{a} четное");
}
else Console.WriteLine($"{a} нечетное");