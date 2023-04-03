Console.Write("Введите имя пользователя: ");

string username = Console.ReadLine();
Console.WriteLine(username);
Console.WriteLine(username.ToLower());

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет Маша");
}
else
{
    Console.Write("Привет, незнакомец - ");
    Console.WriteLine(username);
}