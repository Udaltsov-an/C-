// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2) {
    double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2)+Math.Pow(z2 - z1,2));
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
    int z1 = EnterData("Введите координату z1: ");
    int x2 = EnterData("Введите координату x2: ");
    int y2 = EnterData("Введите координату y2: ");
    int z2 = EnterData("Введите координату z2: ");

double distance = FindDistance(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Расстояние между двумя точками равно {distance}");