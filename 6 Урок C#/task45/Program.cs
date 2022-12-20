// Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементарного копирования.

Console.WriteLine("Введите три числа: ");
Console.Write("Размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Диапозон чисел от: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Диапаозон чисел до: ");
int c = Convert.ToInt32(Console.ReadLine());

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] ");
}
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= rnd.Next(min, max + 1);
    }
return array;
}
int[] arr = CreateArrayRndInt(a, b, c);
int[] newArr = CopyArray(arr);
PrintArray(arr);
Console.WriteLine();
PrintArray(newArr);