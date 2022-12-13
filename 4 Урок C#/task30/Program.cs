// int[] array2 = { 3, 4, 6, 7};
// int[] array1 = new int[5] { 5 , 3 , 3, 7 , 1};
// int[] array = new int[8];


// for (int i = 0; int < array.Length; i++)
// {
//     array[i] = i*i;
// }

int[] array = new int[8];
void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0 , 2);
    }
}
Console.Write("[");
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
}
FillArray(array);
PrintArray(array);
Console.Write("]");