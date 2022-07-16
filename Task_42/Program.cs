// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());

ToBin(number);

void ToBin(int number)
{
    if (number == 0)
    {
        return;
    }
    ToBin(number/2);
    Console.Write(number%2);  
}