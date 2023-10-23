/* 37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (1 < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}
void ProductArray(int[] arr)
{
    int length = arr.Length;
    int result = 0;

    if (length % 2 == 0)
    {
        System.Console.Write("[");
        for (int i = 0; i < length / 2; i++)
        {
            result = arr[i] * arr[length - 1 - i];
            System.Console.Write(result);
            if (i < (length - 1) / 2)
            System.Console.Write(", ");
        }
        System.Console.Write("]");
    }
    if (length % 2 != 0)
    {
        System.Console.Write("[");
        for (int i = 0; i <= length / 2; i++)
        {
            result = arr[i] * arr[length - 1 - i];
            if (arr[length - 1 - i] == arr[length / 2])
            {
                result = arr[length - 1 - i] * 1;
            }
            System.Console.Write(result);
            if (i < (length - 1) / 2)
            System.Console.Write(", ");
        }
        System.Console.Write("]");
    }
}
System.Console.Write("Задайте размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = FillArray(userSize);
PrintArray(userArray);
ProductArray(userArray);
