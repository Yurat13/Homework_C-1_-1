// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int n = new Random().Next(10,99);
int a1 = n % 10;
int max;
int a2 = (n/10) % 10;
if (a1 > a2) max = a1;
else
{
    max = a2;
}
Console.WriteLine("Ваше число: " + n);
Console.WriteLine("Макимальная цифра: " + max);
