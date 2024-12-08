// See https://aka.ms/new-console-template for more information


Console.Write("1den 6ya kadar sayı girin: ");
int number = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int randomNumber = random.Next(1,7);
Console.WriteLine(randomNumber);

if (number == randomNumber)
{
    Console.WriteLine("You Win!");
}else
{
    Console.WriteLine("You Lose!");
}

double randomDouble = random.NextDouble();
Console.WriteLine("RandomDouble: " + randomDouble);

Console.WriteLine();
Console.ReadKey();
