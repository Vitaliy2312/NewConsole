Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username.ToLower() == "сергей")
{
    Console.WriteLine("Привет, ты же АЛКОГОЛИК! ");
}
else
{
    Console.Write("Привет, нормальный человек ");
    Console.WriteLine(username);
}