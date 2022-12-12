// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

void getSum(int number) {
    int result = 0;
    string num = number.ToString();
    for(int i = 0; i < num.Length;i++) {
        result = result + number%10;
        number = number/10;
    }
    Console.WriteLine($"Сумма цифр в числе {num} равна {result}");
}

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int number = EnterData("Введите  число: ");
getSum(number);