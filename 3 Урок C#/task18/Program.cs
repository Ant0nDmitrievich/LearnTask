Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string Range(int num)
    {
        if (num == 1) return "x > 0 и y > 0";
        if (num == 2) return "x < 0 и y > 0";
        if (num == 3) return "x < 0 и y < 0";
        if (num == 4) return "x > 0 и y < 0";
        return "Не принадлежит не одной из четвертей";
    }
string range = Range(num);
//         Console.WriteLine(result);
Console.WriteLine(range);