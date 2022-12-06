Console.Clear();
int num = new Random().Next(100,999);
Console.WriteLine(num);
int a = num/100*10;
// Console.WriteLine(a);
int b = num%10;
// Console.WriteLine(b);
int result = a+b;
Console.WriteLine($"Результат - {result}");