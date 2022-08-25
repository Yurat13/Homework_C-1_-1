// Показать четные числа от 1 до N
Console.WriteLine("Введите число N для дипазона от 1 до N");
int n = int.Parse(Console.ReadLine());
int i = 0;
while (i<n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
i++;
}
