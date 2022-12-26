// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumNumbers(int M, int N) {
    if(M == N) return M;
    int result = M;
    result += GetSumNumbers(M + 1, N);
    return result;
}

int EnterData(string text) {
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int M = EnterData("Введите число M: ");
int N = EnterData("Введите число N: ");
int result = GetSumNumbers(M,N);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {result}");