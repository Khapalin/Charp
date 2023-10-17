/* 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Clear();

/* System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
System.Console.WriteLine(sum);
*/

System.Console.WriteLine("Введите число a: ");

int userA = Convert.ToInt32(Console.ReadLine());
int Summer(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int userResult = Summer(userA);
System.Console.WriteLine(userResult);