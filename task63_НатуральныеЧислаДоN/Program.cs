/* 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

System.Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
void IntN(int number, int current = 1)
{
    if (number < current) return;
    else
    {
        System.Console.Write(current + " ");
        IntN(number, current + 1);
    }
}
IntN(number);