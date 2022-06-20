Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower == "Катя") //ToLower - перед сравнением переводит строку в нижний регистр 
{
    Console.WriteLine("Я тебя люблю, " + username); 
}
else
{
   Console.WriteLine("Привет, " + username); 
}
