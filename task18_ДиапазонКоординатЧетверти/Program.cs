/* Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();

System.Console.WriteLine("Введите номер четверти: ");
int userСvoter = Convert.ToInt32(Console.ReadLine());
if (userСvoter == 1)
{
    System.Console.WriteLine("Все X и Y больше 0");
}
if (userСvoter == 2)
{
    System.Console.WriteLine("Все X меньше 0, Y больше 0");
}
if (userСvoter == 3)
{
    System.Console.WriteLine("Все X и Y меньше 0");
}
if (userСvoter == 4)
{
    System.Console.WriteLine("Все X больше 0, Y меньше 0");
}
if (userСvoter < 1 || userСvoter >= 5)
{
    System.Console.WriteLine("Такой четверти не существует.");
}