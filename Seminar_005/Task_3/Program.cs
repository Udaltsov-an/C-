// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void CreateArray(int count, int begin, int end) {
    int [] array = new int[count];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1);
        
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
CreateArray(12, -9, 9);