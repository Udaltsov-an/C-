// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Palindrom(int n) {
    string number = n.ToString();
    if(number[0] == number[4] && number[1] == number[3]) Console.WriteLine($"Число {n} является палиндромом");
    else Console.WriteLine($"Число {n} не является палиндромом");
}

int EnterData(string text) {
    Console.WriteLine(text);
    int n = int.Parse(Console.ReadLine());
    return n;
}

int n = EnterData("Введите пятизначное число: ");
Palindrom(n);
