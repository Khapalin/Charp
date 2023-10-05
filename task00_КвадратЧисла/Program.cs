/* 
Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
*/


Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber * userNumber;

Console.WriteLine(result);