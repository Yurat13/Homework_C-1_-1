// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число Х");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число Y");
double y = double.Parse(Console.ReadLine());
if (x == y*y)
{
    Console.WriteLine(x +" квадрат " + y);
}
else 
{
    Console.WriteLine(x +" не является квадратом " + y);
}