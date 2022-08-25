// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите 3-х значное число");
int n = int.Parse(Console.ReadLine());
int x;
x = (n/10)%10;
Console.WriteLine(x);