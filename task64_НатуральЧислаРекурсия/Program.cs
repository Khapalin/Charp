/* 64: Задайте значение N. Напишите программу, которая выведет все
 натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/ 
System.Console.WriteLine("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
void IntN(int number, int current = 1)
{
    if (number < current) return;
    else
    {
        System.Console.Write(number + " ");
        IntN(number - 1, current);
    }
}
IntN(userNumber);