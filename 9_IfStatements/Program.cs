// See https://aka.ms/new-console-template for more information

String userName,password;

Console.WriteLine("Enter your username: ");
userName = Console.ReadLine();

Console.WriteLine("Enter your password: ");
password = Console.ReadLine();

if(password == "admin123" && userName == "admin"){
    Console.WriteLine("Logined...");
}else if(password == "admin123" && userName != "admin"){
    Console.WriteLine("Username is not correct!");
}else if(password != "admin123" && userName == "admin"){
    Console.WriteLine("Password is not correct!");
}else{
    Console.WriteLine("Username and password are not correct");
}



Console.ReadKey();