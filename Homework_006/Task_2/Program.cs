// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCross(double b1, double k1, double b2, double k2) {
    double x0 = ((b2-b1)/(k1-k2));
    double y0 = (k1 * x0 + b1);
    Console.WriteLine($"Точка пересечения двух прямых [{x0};{y0}]");    
}

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int b1 = EnterData("Введите значание b1: ");
int k1 = EnterData("Введите значание k1: ");
int b2 = EnterData("Введите значание b2: ");
int k2 = EnterData("Введите значание k2: ");
FindCross(b1,k1,b2,k2);