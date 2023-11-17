/* 58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/
Console.Write("Укажите количество строк для первой матрицы: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Укажите количество столбцов для первой матрицы: ");
int cols = int.Parse(Console.ReadLine());
Console.Write("Укажите количество строк для второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Укажите количество столбцов для второй матрицы: ");
int cols2 = int.Parse(Console.ReadLine());

int[,] matrixA = new int[rows, cols];
int[,] matrixB = new int[rows2, cols2];
int[,] resultArray = new int[rows, cols2];

FillArray(matrixA);
Console.WriteLine("Первый массив:");
PrintArray(matrixA);

FillArray(matrixB);
Console.WriteLine("Второй массив:");
PrintArray(matrixB);

MultiplyIfPossible(matrixA, matrixB);
resultArray = MatrixMultiplication(matrixA, matrixB);

Console.WriteLine("Результат умножения матриц:");
PrintMatrix(resultArray);
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

void FillArray(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }
}

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Нельзя перемножить матрицы");
        }
        else
        {
            int[,] resultArray = MatrixMultiplication(matrixA, matrixB);
            PrintMatrix(resultArray);
        }
    }

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] resultArray = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                resultArray[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultArray;
}
void PrintMatrix(int[,] matrix)
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