/* 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/ 
Console.WriteLine("Enter the number of m for the matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of n for the matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the k value for each element: ");
int k = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateIncreasingMatrix(n, m, k);
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
   int[,] matrix = new int[n, m];
   int number = 1;
   for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = number;
            number += k;
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
  int n = matrix.GetLength(0);
  int m = matrix.GetLength(1);
  for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
        Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
        }
}
double [] FindAverageInColumns (int [,] matrix)
 {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] result = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + matrix[i, j];
        }
        result[j] = Math.Round((sum / rows),1);
    }
    return result;
    }
   void PrintListAvr(double[] result)
{
    Console.WriteLine("The averages in columns are:");
   for (int i = 0; i < result.Length; i++)
   {
       Console.Write($"{result[i]:f2}"+"\t");
   }
   Console.WriteLine();
}
 double[] result = FindAverageInColumns(matrix);
PrintArray(matrix);
PrintListAvr(result);