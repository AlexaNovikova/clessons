// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "sasha"){
    Console.WriteLine("Ура, это же Саша");

}
else{
    Console.WriteLine("Привет " + username);
}
