// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ProductOfNumbers(int[,] matrix1, int[,] matrix2) {
    int[,] result = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++) {
        for(int j = 0; j < matrix1.GetLength(1); j++) {
            for(int k = 0; k < matrix1.GetLength(0); k++) {
                result[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return result;
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
int[,] matrix1 = FillArray(rows, columns, 1, 9);
int[,] matrix2 = FillArray(rows, columns, 1, 9);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
int[,] result = ProductOfNumbers(matrix1,matrix2);
PrintArray(result);