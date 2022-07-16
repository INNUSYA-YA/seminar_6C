// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.Write("ВВедите N ");
int n = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = new int[n];
FillArray(fibonacci);
if(fibonacci.Length>0) fibonacci[0]=0;
if (fibonacci.Length>1) fibonacci[1]=1;
for(int i =2;i<fibonacci.Length;i++)
 {
    
    fibonacci[i] = fibonacci[i-2]+fibonacci[i-1];
 }
PrintArray(fibonacci);
void FillArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
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