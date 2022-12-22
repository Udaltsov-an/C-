// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Мансур Рустэмович: Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

void FindEven(int[,] matrix) {
    for(int i = 1; i < matrix.GetLength(0); i++){
        for(int j = 1; j < matrix.GetLength(1); j++){
            if(i % 2 == 0 && j % 2 == 0){
                matrix[i,j] *= matrix[i,j];
            }
        }
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 1; i < rows; i++)
    {
        for(int j = 1; j < columns; j++) {
            matrix[i,j] = new Random().Next(begin, end + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int rows = EnterData("Введите количество строк");
int columns = EnterData("Введите количество столбцов");

int[,] matrix = FillArray(rows, columns, 1, 9);
PrintArray(matrix);
FindEven(matrix);
Console.WriteLine();
PrintArray(matrix);