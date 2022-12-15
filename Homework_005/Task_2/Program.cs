// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int count, int begin, int end) {
    int[] array = new int[count];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}

void SumNotEvenPos(int[] array) {
    int sum = 0;
    for(int i = 0; i < array.Length; i++ ) {
        if(i%2 != 0) {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов нечётных позиция равна {sum}.");
}

SumNotEvenPos(CreateArray(5,-10,10));