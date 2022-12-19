// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

int[] CreateArray(int count, int begin, int end) {
    int[] array = new int[count];
    for(int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(begin,end + 1);
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return array;
}

int[] array = CreateArray(4, 0, 10);
Array.Reverse(array);
Console.WriteLine($"[{string.Join(", ", array)}]");