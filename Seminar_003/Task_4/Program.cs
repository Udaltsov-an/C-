// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Table(int n) {
    for(int i = 1; i <= n; i++) {
        int result = i*i;
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