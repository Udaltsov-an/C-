// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
string[] weekDays = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите число от 1 до 7");
int day = int.Parse(Console.ReadLine());
int i = day - 1;
if (i == 5 || i == 6) {
    Console.WriteLine($"{weekDays[i]} - это выходной");
}
else Console.WriteLine($"{weekDays[i]} - это не выходной");