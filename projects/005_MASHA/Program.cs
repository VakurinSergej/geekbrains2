// Как приветствовать пользователя-любимчика

Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
// if(username == "Маша")
// if(username.ToLower() == "Маша")
if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

