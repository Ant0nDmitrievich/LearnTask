Console.WriteLine("Введите 2 числа:");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int Multiple(int num1, int num2)
    {
        return num1 % num2;
    }
int res = Multiple(number1, number2);
    if (res == 0)
        {
            Console.WriteLine("Кратно");
        }
else Console.WriteLine($"Не кратно, остаток {res}");