// Удалить вторую цифру трёхзначного числа
int n = new Random().Next(100,1000);
Console.WriteLine(n);
int a3 = n % 10;
int a2 = (n/10)%10;
int a1 = (n/100)%10;
Console.Write(a1);
Console.Write(a3);