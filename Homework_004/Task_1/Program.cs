// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int a = EnterData("Введите  число A: ");
int b = EnterData("Введите  число B: ");
int result = a;
for(int i = 1; i < b; i++) {
    result *= a;
}
Console.WriteLine($"{a} в степени {b} равно {result}");