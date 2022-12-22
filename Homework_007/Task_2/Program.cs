// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
void FindElement(int find_rows, int find_columns, int[,] matrix) {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    if(find_rows > rows || find_columns > columns) Console.WriteLine("Такого числа в массиве нет");
    for(int i = 0; i < rows;i++) {
        for(int j = 0; j < columns; j++)
        {
            if(find_rows == i && find_columns == j) {
                Console.WriteLine($"На позиции строка {find_rows} и столбец {find_columns} находится число {matrix[i,j]}");
                break;
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
        for(int j = 0; j < columns; j++) {
            matrix[i,j] = new Random().Next(begin, end + 1);
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int rows = EnterData("Введите количество строк");
int columns = EnterData("Введите количество столбцов");

int[,] matrix = FillArray(rows, columns, 0, 100);
PrintArray(matrix);
int find_rows = EnterData("Введите искомую строку");
int find_columns = EnterData("Введите искомый столбец");
FindElement(find_rows, find_columns, matrix);
