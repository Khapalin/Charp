﻿/* 16.Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет

int result1 = number1 * number1;
int result2 = number2 / number1;
System.Console.WriteLine(result2);
*/

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if(number1 * number1 == number2 || number2 * number2 == number1)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
