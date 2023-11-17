/* 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов. возвращает массив из двух элементов: номер строки 
с наименьшей суммой (нумерация начинается с 0) и саму сумму.
*/ 
int[,] matrix = new int[4, 4];
FillArrayRandom(matrix);
PrintArray(matrix);
Console.WriteLine();
NumberRowMinSumElements(matrix);
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0; //Сумма минимальная в строчке
    int minSumRow = 0;// номер строки минимальной
    int sumRow = 0;// Сумма строки
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRow += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumRow += matrix[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка, сумма =  {minRow}");
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}