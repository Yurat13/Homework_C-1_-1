// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int x = int.Parse (Console.ReadLine());
int a3 = x % 10;
//int a2 = (x/10) % 10;
int a1 = (x/100) % 10;
if (a1 == 0)
{
    Console.WriteLine("Число не трехзначное");
}
else 
{
    Console.WriteLine(a3);
}
