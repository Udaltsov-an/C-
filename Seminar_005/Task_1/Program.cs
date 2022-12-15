// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void CalcSumAndDiffArr(int count, int begin, int end) {
    int [] array = new int[count];
    int sum = 0;
    int diff = 0;
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1);
        if (array[i] > 0) {
            sum = sum + array[i];
        }
        else {
            diff = diff + array[i];
        }
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    Console.WriteLine($"Сумма положительных чисел равна {sum}");
    Console.WriteLine($"Сумма отрицательных чисел равна {diff}");
}
CalcSumAndDiffArr(12, -9, 9);
