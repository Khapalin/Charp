/* 67 Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/
System.Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumber(int num)
{
    if (num % 10 > 0) return num % 10 + SumNumber(num / 10);
    else return 0;
}
int result = SumNumber(number);
System.Console.WriteLine(result);