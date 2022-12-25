// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,,] FillArray(int first, int second, int third, int begin, int end)
{
    int[,,] matrix = new int[first, second, third];
    for (int i = 0; i < first; i++)
    {
        for (int j = 0; j < second; j++)
        {
            for (int k = 0; k < third; k++)
            {
                matrix[i, j, k] = new Random().Next(begin, end + 1);
                if(matrix[i,j,k] == matrix[i,j,k]) matrix[i,j,k] = new Random().Next(begin, end + 1);
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i,j,k]}{(i,j,k)} ");
            }
            Console.WriteLine();
        }
    }
}

int first = EnterData("Введите количество первых координат");
int second = EnterData("Введите количество вторых координат");
int third = EnterData("Введите количество третьих координат");
int[,,] matrix = FillArray(first, second, third, 10, 99);
PrintArray(matrix);