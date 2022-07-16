// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());
string a = "";

while(number>0)
{
    a = number%2+a;
    number/=2;
}
Console.WriteLine(a);