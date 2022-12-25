// адача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void DeleteRowsAndColumns(int[,] matrix) {
    int min = matrix[0,0];
    int mini = 0;
    int minj = 0;
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            if(matrix[i,j] < min) {
                min = matrix[i,j];
                mini = i;
                minj = j;
            }
        }
    }

   int[,] updatearray = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

   for(int i = 0; i < matrix.GetLength(0); i++) {
    for(int j = 0; j < matrix.GetLength(1); j++) {
        if(j != minj && i != mini) updatearray[i,j] = matrix[i,j];
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
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(begin, end + 1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rows = EnterData("Введите количество строк");
int columns = EnterData("Введите количество столбцов");
int[,] matrix = FillArray(rows, columns, 1, 9);
PrintArray(matrix);
Console.WriteLine();
int[,] updatearray = DeleteRowsAndColumns(matrix);
