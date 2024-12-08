// See https://aka.ms/new-console-template for more information


int num = -3;

num = (int) Math.Pow(num, 4);

num = (int) Math.Sqrt(num);

num = Math.Abs(-4);
Console.WriteLine(num);

double num2 = Math.Ceiling(3.09); //üst basamağa
Console.WriteLine("Ceiling: " + num2);

num2 = Math.Round(3.09);
Console.WriteLine("Round: " + num2); //en yakın olana;

num2 = Math.Floor(3.9);
Console.WriteLine("Floor: " + num2);

Console.WriteLine("Max: " + Math.Max(3,3.1));

Console.WriteLine("Min: " + Math.Min(3, 3.1));


Console.ReadKey();
