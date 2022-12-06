// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) System.Console.WriteLine("1 -> нет");
else if (day == 2) System.Console.WriteLine("2 -> нет");
else if (day == 3) System.Console.WriteLine("3 -> нет");
else if (day == 4) System.Console.WriteLine("4 -> нет");
else if (day == 5) System.Console.WriteLine("5 -> нет");
else if (day == 6) System.Console.WriteLine("6 -> да");
else if (day == 7) System.Console.WriteLine("7 -> да");
else System.Console.WriteLine("Введено неверное число");