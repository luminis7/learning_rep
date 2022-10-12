Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "света")
{
    Console.WriteLine("Ура, это Света!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}