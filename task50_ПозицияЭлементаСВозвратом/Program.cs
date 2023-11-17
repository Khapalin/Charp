/* 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
*/


Console.WriteLine("Enter the number of m for the matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of n for the matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the k value for each element: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateIncreasingMatrix(m, n, k);
Console.WriteLine("Enter the position of the number to find (x): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the position of the number to find (y): ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] CreateIncreasingMatrix(int m, int n, int k)
{
   int[,] matrix = new int[m, n];
   int number = 0;
   for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = number;
            number += k;
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
  int m = matrix.GetLength(0);
  int n = matrix.GetLength(1);
  for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
        }
}
int[] FindNumberByPosition(int[,] matrix, int x, int y)
{
 int m = matrix.GetLength(0);
 int n = matrix.GetLength(1);
if (x >= m || y >= n)
    {
     return new int[1];
    }
    int number = matrix[x, y];
    return new int[] { number, 0 };
    }
void PrintCheckIfError(int[] result, int x, int y)
{
    if (result.Length == 1)
    {
    Console.WriteLine("There is no such index");
    }
    else
    {
    Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
    }
}
PrintArray(matrix);
int[] result = FindNumberByPosition(matrix, x, y);
PrintCheckIfError(result, x, y);