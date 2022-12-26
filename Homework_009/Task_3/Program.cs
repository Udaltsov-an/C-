// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0 && M != 0) return FunctionAkkerman(M - 1, 1);
    else return FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int N = int.Parse(Console.ReadLine());
    return N;
}

int M = EnterData("Введите число M (больше либо равное нулю): ");
int N = EnterData("Введите число N (больше либо равное нулю): ");
Console.Write(FunctionAkkerman(M, N));