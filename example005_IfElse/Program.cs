System.Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    System.Console.WriteLine("Ура, это же МАША!");
} 
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}
