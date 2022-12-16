// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




// Я зашиваюсь уже с учебой, я все доделаю, обещаю, мне это нужно самому
// просто никак сегодня не успею и так дотянул до последнего, извините пожалуйста





int[] array = new int[4];
void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100 , 1000);
    }
}
void PrintArray (int[] array)
{
    Console.Write("[");
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", ");
        Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int GetEvenNum(int array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] / 2) even ++; 
    }
    return even;
}
FillArray(array);
GetEvenNum(array);
PrintArray(array);
