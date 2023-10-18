/* Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.
*/

Console.Clear();

System.Console.WriteLine("Введите координаты точки A (x, y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x, y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

double squareX = Math.Pow(userBx - userAx, 2); //Math.Pow(a, 2);ф-ия возведения в степень(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY); //Math.Sqrt(squareX + squareY); находит квадратный корень.

System.Console.WriteLine(Math.Round(rootXY, 2)); //Math.Round(a, 2) Округляет значение до ближайшего целого или указанного количества десятичных знаков после запятой.
 
