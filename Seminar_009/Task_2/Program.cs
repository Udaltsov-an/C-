// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int GetNaturalNumbers(int M, int N)
{
    if (N == M) return M;
    else Console.Write(GetNaturalNumbers(M, N - 1) + ", ");
    return N;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int M = EnterData("Введите число M: ");
int N = EnterData("Введите число N: ");
Console.Write(GetNaturalNumbers(M, N));