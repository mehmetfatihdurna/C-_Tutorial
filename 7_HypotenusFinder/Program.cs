// See https://aka.ms/new-console-template for more information


double A,B,hypotenus;

Console.Write("A kenarını girin: ");
A = Convert.ToDouble(Console.ReadLine());

Console.Write("B kenarını girin: ");
B = Convert.ToDouble(Console.ReadLine());

hypotenus = Math.Sqrt(Math.Pow(A,2) + Math.Pow(B,2));

Console.WriteLine("Hypotenus: " + hypotenus);

Console.ReadKey();
