/* 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/


using System;
Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j];
        }
    }
    return result;
}

int[,] ChangeRows(int[,] array)
{
    int temperary = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temperary = result[0, j];
        result[0, j] = result[array.GetLength(0) - 1, j];
        result[array.GetLength(0) - 1, j] = temperary;
    }
    return result;
}

int[,] ReplaceRowsColumns(int[,] array)
{
    int[,] result = CopyArray(array);
    int temporary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (i != j)
            {
                temporary = result[i, j];
                result[i, j] = result[j, i];
                result[j, i] = temporary;
            }
        }
    }
    return result;
}

int userArrayRow = TakeEnteredNumber("Введите количество строк и столбцов:");
int userArrayColumn = userArrayRow;
int userArrayStart = TakeEnteredNumber("Введите начало диапазона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);

int[,] userArray2 = ReplaceRowsColumns(user2DArray);
System.Console.WriteLine();
Print2DArray(userArray2);