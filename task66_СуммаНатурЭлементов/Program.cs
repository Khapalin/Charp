/* 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
System.Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numM, int numN)
{
    if (numM <= numN)
    {
        return numM + SumNumber(numM + 1, numN);
    }
    else return 0;
}
int result = SumNumber(numberM, numberN);
System.Console.WriteLine(result);