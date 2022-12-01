Console.Clear();

Console.WriteLine("Введите число second: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число first: ");
int first = int.Parse(Console.ReadLine());

int result = second * second;

if(result == first) {
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");