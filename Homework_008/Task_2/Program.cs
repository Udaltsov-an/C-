// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FindMinSumRow(int[,] matrix)
{
    int result = 0;
    int indexrow = 0;
    int sumrow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow += matrix[i, j];
        }
        if(i == 0) result = sumrow;
        if (sumrow < result)
            {
                result = sumrow;
                indexrow = i;
            }
    }
    Console.WriteLine($"Минимальная сумма на строке {indexrow} равна {result}");
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
FindMinSumRow(matrix);