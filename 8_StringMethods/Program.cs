// See https://aka.ms/new-console-template for more information



String fullName = "Mehmet Fatih";
String phoneNumber = "0551-173-54-20";


Console.WriteLine(fullName.ToUpper());
Console.WriteLine(fullName.ToLower());

Console.WriteLine(phoneNumber.Replace('-',' ')); // \0 is null char
Console.WriteLine(phoneNumber.Replace("-", "")); 
Console.WriteLine(fullName.Insert(0,"@"));
Console.WriteLine(fullName.Length);
Console.WriteLine(fullName[..6]); //fullName.Substring(9,6)
Console.WriteLine(fullName[3..fullName.Length]);
Console.ReadKey();
