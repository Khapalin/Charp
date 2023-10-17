/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Clear();

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i /= 10)
{
    revN = revN * 10 + i % 10;
    //System.Console.WriteLine(revN);
}
if (N == revN)
    System.Console.WriteLine("Это ПАЛИНДРОМ!");
else System.Console.WriteLine("Это не палиндром...");
