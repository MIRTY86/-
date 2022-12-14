Console.Write("Введите имя:");
string username = Console.ReadLine();

if(username.ToLower() == "дима")
{
    Console.WriteLine("Ура, это же Дима!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}


