// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArray(int count, int begin, int end) {
    int[] array = new int[count];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}

void FindEven(int[] array) {
    int count = 0;

    for(int i = 0; i < array.Length; i++) {
        if(array[i]%2 == 0) {
            count++;
        }
    }
    Console.WriteLine($"Массив имеет {count} чётных элементов.");
}

FindEven(CreateArray(10,100,1000));