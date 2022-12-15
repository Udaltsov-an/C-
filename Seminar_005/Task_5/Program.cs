// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int count, int begin, int end) {
    int[] array = new int[count];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}

void Test(int[] array){
    int[] temp = new int[array.Length/2];
    for(int i = 0; i < array.Length/2; i++) {
        temp[i] = array[i]*array[array.Length-i-1];
    }
    Console.WriteLine($"[{string.Join(", ", temp)}]");
}
Console.Clear();
Test(CreateArray(6, 1, 5));