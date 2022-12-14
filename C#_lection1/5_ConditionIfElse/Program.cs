Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "вартан")
{
    Console.WriteLine("Ура, это же Вартан!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}