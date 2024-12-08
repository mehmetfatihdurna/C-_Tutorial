// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bölmek istediğiniz sayıları giriniz...");

try{
    Console.Write("Sayı1: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Sayı2: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bölüm: " + (num1 / num2));
}catch(FormatException e){
    Console.WriteLine(e.GetType().Name + ": " + e.Message + " Please enter only number.");
}catch(DivideByZeroException e){
    Console.WriteLine(e.GetType().Name + ": " + e.Message + " Any number cannot divide by zero.");   
}finally{
    Console.WriteLine("Have a nice day");
}

