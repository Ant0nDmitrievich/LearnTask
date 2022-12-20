// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите три числа: ");
Console.Write("Первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool Triangle (int a, int b, int c)
{
    return a < (b + c) && b < (a + c)  && c < (a + b);
}
Console.WriteLine(Triangle(a, b, c) ? $"Треугольник со сторонами {a}, {b}, {c} -> может существовать" : $"Треугольник со сторонами {a}, {b}, {c} -> не может существовать");