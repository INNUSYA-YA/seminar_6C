//  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Console.Write("ВВедите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if(a+b>c&&a+c>b&&b+c>a)
{
    Console.WriteLine("треугольник сo сторонами такой длины может существовать");
}
else
{
    Console.WriteLine("треугольник сo сторонами такой длины  не может существовать");
}