// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

int EnterData(string text) {
    Console.WriteLine(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int n = EnterData("Введите число: ");

string result = Convert.ToString(n, 2);
Console.WriteLine(result);