Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int i = -N;
while(i<=N) {
    Console.WriteLine($"{i}");
    i++;
}