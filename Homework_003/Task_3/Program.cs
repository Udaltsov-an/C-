// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void Table(int n) {
    for(int i = 1; i <= n; i++) {
        int result = i*i*i;
        Console.Write($"{result}, ");
    }
}

int EnterData(string text) {
    Console.WriteLine(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int n = EnterData("Введите число: ");
Table(n);