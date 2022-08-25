// Выяснить, кратно ли число заданному, если нет, вывести остаток.
double n = new Random().Next(1,10000);
Console.WriteLine(n);
Console.WriteLine("Введите число");
double x = double.Parse (Console.ReadLine());
double result;
if ((n % x) == 0)
{
    result = n/x;
    Console.WriteLine("Частное:" + result);
    Console.WriteLine("Число " + x + " кратно числу " + n);
}
else 
{
    result = n/x;
    Console.WriteLine("Число " + x + " не кратно числу " + n + ", остаток " + n%x);
    Console.WriteLine("Частное: " + result);
}
