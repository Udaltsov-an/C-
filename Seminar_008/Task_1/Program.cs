// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void ChangeFirstAndLastRows(int[,] matrix) {
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            if(i == 0) {
                int temp = matrix[i,j];
                matrix[i,j] = matrix[matrix.GetLength(0)-1,j];
                matrix[matrix.GetLength(0)-1,j] = temp;
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
ChangeFirstAndLastRows(matrix);
Console.WriteLine();
PrintArray(matrix);