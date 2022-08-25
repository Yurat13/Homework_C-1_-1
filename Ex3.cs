// Найти максимальное из трех чисел
Console.WriteLine("Введите 1-ое число");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-ое число");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3-ое число");
int a3 = int.Parse(Console.ReadLine());
int max = a1;
if (a2 > a1) max = a2;
if (a3 > a2) max = a3;
Console.WriteLine("Максимальное число " + max);
