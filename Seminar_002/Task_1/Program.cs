Console.Clear();
int number = new Random().Next(10,99);
Console.WriteLine(number);

int a = number/10;
int b = number%10;
int max = a;
if(max<b) max = b;
Console.WriteLine($"Максимальное число - {max}");