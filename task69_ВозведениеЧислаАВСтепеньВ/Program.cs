/* 69 Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B
с помощью рекурсии.
*/

System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int Degree(int numA, int numB)
{
    if (numB == 1) return numA;
    else return numA * Degree(numA, numB - 1);
}
int result = Degree(numberA, numberB);
System.Console.WriteLine(result);