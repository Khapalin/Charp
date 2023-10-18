Console.Write("Введите самое прекрасное имя в мире: ");
string username = Console.ReadLine();

if(username.ToLower() == "Наташенька")
{
    Console.WriteLine("Ура! Это же Наташенька!");
}
else
{
    Console.Write("Конечно, ");
    Console.WriteLine(username);
}