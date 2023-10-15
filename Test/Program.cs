// Задача 1 Палиндром

bool result = number >= 10000 && number <= 99999;
 if ( number > 9999 && number < 100000) 
 {
     return result;
 }
 else 
 {
     Console.WriteLine("Число не пятизначное") ;
     return result; 
 } 

/* задача 2 напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB 
в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.
*/

double squareX = Math.Pow(pointB[0] - pointA[0], 2);
double squareY = Math.Pow(pointB[1] - pointA[1], 2);
double squareZ = Math.Pow(pointB[2] - pointA[2], 2);
double result = Math.Sqrt(squareX + squareY + squareZ);
      return result;

/* напишите метод ShowCube, который принимает на вход число (N) 
и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/

for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}