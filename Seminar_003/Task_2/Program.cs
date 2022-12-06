// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Методы
int FindCoordinates(int quarter) {
    if(quarter == 1) Console.WriteLine("Диапазон возможных чисел: x > 0 и y > 0");
    if(quarter == 2) Console.WriteLine("Диапазон возможных чисел: x < 0 и y > 0");
    if(quarter == 3) Console.WriteLine("Диапазон возможных чисел: x < 0 и y < 0");
    if(quarter == 4) Console.WriteLine("Диапазон возможных чисел: x > 0 и y < 0");
    return quarter;
}

int EnterData(string text) {
    Console.WriteLine(text);
    int quarter = int.Parse(Console.ReadLine());
    return quarter;
}
// Ввод четверти
int quarter = EnterData("Введите номер четверти: ");
// Поиск диапазона координат
quarter = FindCoordinates(quarter);
