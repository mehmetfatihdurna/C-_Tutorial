// See https://aka.ms/new-console-template for more information
using _19_OverLoadedConstructors;

Console.WriteLine("Hello, World!");


Pizza pizza1 = new Pizza("Kalın Kenar", "Hot Chili Souce", "Mozzarella");

Pizza pizza2 = new Pizza("İnce Kenar", "Dinamit Souce", "Cheedar", "Pepperoni");

pizza2.Print();

pizza1.Print();