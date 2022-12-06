// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Методы
double FindDistance(int x1, int y1, int x2, int y2) {
    double distance = Math.Sqrt(Math.Pow(x2- x1, 2) + Math.Pow(y2- y1, 2));
    return distance;
}

int EnterData(string text) {
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
// Ввод данных
    int x1 = EnterData("Введите координату x1: ");
    int y1 = EnterData("Введите координату y1: ");
    int x2 = EnterData("Введите координату x2: ");
    int y2 = EnterData("Введите координату y2: ");
// Вывод данных
double distance = FindDistance(x1,y1,x2,y2);
Console.WriteLine($"Расстояние между двумя точками равно {distance}");