// Выяснить является ли число чётным
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}