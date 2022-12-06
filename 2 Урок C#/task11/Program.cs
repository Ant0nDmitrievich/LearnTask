int number = new Random().Next(100, 1000);

Console.WriteLine($"Случайное трехзначное число {number}");

int MinusMiddle(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int number1 = MinusMiddle(number);

Console.WriteLine($"Искомая цифра {number1}");


