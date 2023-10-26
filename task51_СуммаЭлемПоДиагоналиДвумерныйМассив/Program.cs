/* 51. Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/


Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end+1);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int MainDiagonalSumm (int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j) result = result + array [i,j];
        }
    }
    return result;        
}


int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);

int userMainDiagonalSum =  MainDiagonalSumm(user2DArray);
System.Console.WriteLine(userMainDiagonalSum);


/*
Console.Clear();
int[,] GetRandomArray(int strg, int stlb)
{
    int[,] array = new int[strg, stlb];
    for (int i = 0; i < strg; i++)
    {
        for (int j = 0; j < stlb; j++)
        {
            array[i, j] = new Random(). Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j]+ "\t");
           
        }
        System.Console.WriteLine();  
    }
}
int SumIndx(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i,i]; 
    }
    return sum;
}

System.Console.WriteLine("Введите кол-во строк: ");
int userStrg = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-то столбцов: ");
int userStlb = Convert.ToInt32(Console.ReadLine());
int[,] userArray = GetRandomArray(userStrg, userStlb);
PrintArray(userArray);
int userSum = SumIndx(userArray);
System.Console.WriteLine(userSum);
*/