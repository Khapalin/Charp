/* 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
 
System.Console.WriteLine("Введите число А: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В: ");
int userB = Convert.ToInt32(Console.ReadLine());
/*
void NatStep(int a, int b)
{
    double result = Math.Pow(a, b);
    System.Console.WriteLine("Число " + userA + " возведенное в степень " + userB + " это " + result);
    System.Console.WriteLine(userA + ", " + userB + " -> " + result);
}
NatStep(userA, userB);

*/
void NatStep(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}
NatStep(userA, userB);