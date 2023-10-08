/* Внутри класса Answer напишите метод CompareNumbers, 
* который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
* a = 5; b = 7 -> Первое число 5 меньше чем второе число 7
* a = 2; b = 2 -> Введенные числа равны 2
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1 + " больше чем " + number2);
}
else if (number2 > number1)
{
    System.Console.WriteLine($"{number2} больше чем {number1}");
}
else if (number1 == number2)
{
    System.Console.WriteLine(number1 + " равно " + number2);
}