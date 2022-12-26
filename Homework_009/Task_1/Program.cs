// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void GetNaturalNumbers(int N) {
    if (N == 0) return;
    Console.Write($"{N}, ");
    GetNaturalNumbers(N - 1);
}

int EnterData(string text) {
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int N = EnterData("Введите число: ");
GetNaturalNumbers(N);