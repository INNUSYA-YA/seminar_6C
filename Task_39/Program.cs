// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
Console.Write("ВВедите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
FillArray(numbers);
PrintArray(numbers);

for(int i = 0; i<numbers.Length/2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length-1-i];
    numbers[numbers.Length-1-i]=temp;
}
PrintArray(numbers);
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

