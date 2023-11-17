/* 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/ 
System.Console.WriteLine("Введите число m: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число n: ");
int nNumber = Convert.ToInt32(Console.ReadLine());
int Ackerman(int mNum, int nNum)
{
    if (mNum == 0)
    {
        return nNum + 1;
    }
    else if (mNum != 0 && nNum == 0)
    {
        return Ackerman(mNum - 1, 1);
    }
    else
    {
        return Ackerman(mNum - 1, Ackerman(mNum, nNum - 1));
    }
}
int result = Ackerman(mNumber, nNumber);
System.Console.WriteLine(result);