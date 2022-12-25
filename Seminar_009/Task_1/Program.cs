// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int GetNaturalNumbers(int N) {
    if (N == 1) return 1;
    else Console.Write(GetNaturalNumbers(N - 1) + ", ");
    return N;
}

int EnterData(string text) {
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int N = EnterData("Введите число: ");
// GetNaturalNumbers(N);
Console.Write(GetNaturalNumbers(N));