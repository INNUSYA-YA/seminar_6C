// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Write("ВВедите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillArray(numbers);
int[] copy = CoppyArray(numbers);
PrintArray(numbers);
PrintArray(copy);

int[] CoppyArray(int[] array)
{
    int[] coppyArray = new int[array.Length];
    for (int i = 0; i<numbers.Length; i++)
    {
        coppyArray[i] = array[i];
    }
    return coppyArray;
}

void FillArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
}
void PrintArray(int[] array)
{
for (int i = 0; i<array.Length; i++)
{
    Console.Write(array[i]+ " ");
}
Console.WriteLine();
}
