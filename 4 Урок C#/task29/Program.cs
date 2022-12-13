// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[8];
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0 , 1000);
    }
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", ");
        Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
FillArray(array);
PrintArray(array);
