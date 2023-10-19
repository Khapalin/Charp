Console.Clear();

Console.Write("Введите самое прекрасное имя в мире: ");
string username = Console.ReadLine();

if(username.ToLower() == "серега")
{
    Console.WriteLine("Правильно! Серега это четкое имя!");
}
else
    Console.Write(username + "хуёвое имя... ");
    