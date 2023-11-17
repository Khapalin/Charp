/* 65 Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/
System.Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
void IntN(int numM, int numN)
{
    if (numM > numN) return;
    else
    {
        System.Console.Write(numM + " ");
        IntN(numM + 1, numN);
    }
}
IntN(numberM, numberN);