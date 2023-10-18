/* 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();

System.Console.WriteLine("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Number(int a)
{
    int num = 0;
    for (int i = userNum; i > 0; i= i/10)
    {
        num =  num + 1;
    }
    return num;
}
int userResalt = Number(userNum);
System.Console.WriteLine(userResalt);