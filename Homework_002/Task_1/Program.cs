﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
string num = number.ToString();
Console.WriteLine($"Вторая цифра числа {number} - это {num[1]}");