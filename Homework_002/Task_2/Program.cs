// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());
if(number < 100) {
    Console.WriteLine("Третьей цифры нет!");
}
else {
    string num = number.ToString();
    Console.WriteLine($"Третья цифра - {num[2]}");
}
