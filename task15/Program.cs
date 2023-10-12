/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <= 5 && dayNumber > 0)
{
    System.Console.WriteLine("Это рабочий день!");
}
if (dayNumber == 6 || dayNumber == 7)
{
    System.Console.WriteLine("Ура выходной!");
}
if (dayNumber < 1 || dayNumber > 7)
{
    System.Console.WriteLine("Такого дня недели не существует!");
}