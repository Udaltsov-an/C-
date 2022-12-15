// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FindDiff(double[] array) {
    double max = 0;
    double min = 0;
    double result = 0;
    for(int i = 0; i < array.Length; i++) {
        max = array.Max();
        min = array.Min();
        result = max - min;
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {result}");
}

double[] CreateArray(int count, int begin, int end) {
    double[] array = new double[count];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1) + Math.Round(new Random().NextDouble(), 2);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}
Console.Clear();
FindDiff(CreateArray(5, 1, 15));