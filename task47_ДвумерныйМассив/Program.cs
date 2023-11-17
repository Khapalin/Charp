/* 47 Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами
*/ 


System.Console.Write("Укажите количество строк: ");
int userM = int.Parse(System.Console.ReadLine());
System.Console.Write("Укажите количество столбцов: ");
int userN = int.Parse(System.Console.ReadLine());
Console.WriteLine("Минимальная граница чисел: ");
int minLimitRandom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальная граница чисел: ");
int maxLimitRandom = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[userM, userN];
Random num = new Random();
void PrintArray(double[,] matr)
{

    for (int i = 0; i < userM; i++)
    {
        for (int j = 0; j < userN; j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void CreateRandomMatrix(double[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
      matrix[i, j] = Math.Round((num.NextDouble() * maxLimitRandom - minLimitRandom) + minLimitRandom, 1);
        }
    }
}


CreateRandomMatrix(matrix);
System.Console.WriteLine();
PrintArray(matrix);