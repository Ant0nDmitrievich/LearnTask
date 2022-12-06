Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MultiplicityTwoDigit(int num)
    {
        return num % 7 == 0 && num % 23 == 0;
    }

bool result = MultiplicityTwoDigit(number);
string resultStr = result ? "Да" : "Нет";
Console.WriteLine($"{number} -> {resultStr}");