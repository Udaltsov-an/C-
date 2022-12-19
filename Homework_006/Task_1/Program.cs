// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void EnterNumbers(int M) {
    int count = 0;
    for (int i = 1; i < M+1; i++) {
        int number = EnterData($"Введите число {i}: ");
        if(number > 0) count += 1;
    }
    Console.WriteLine($"Количество чисел больше нуля {count}");
}

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int M = EnterData("Введите количество вводимых чисел: ");
EnterNumbers(M);
