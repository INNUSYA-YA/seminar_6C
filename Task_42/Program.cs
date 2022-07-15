// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("ВВедите число ");
int a = Convert.ToInt32(Console.ReadLine());
string b = "";

while (a>0)
{
    b = a%2+b;
    a/=2;
}
Console.WriteLine(b);