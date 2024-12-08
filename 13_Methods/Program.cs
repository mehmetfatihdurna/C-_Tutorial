// Top-level statements
Multiplier multiplier = new Multiplier();
Console.WriteLine("İki adet double değer: 2.5 ve 4.0");
double result1 = multiplier.Multiply(2.5, 4.0);
Console.WriteLine($"Sonuç (iki sayı): {result1}");

Console.WriteLine("\nBir dizi: [1.2, 3.4, 5.6]");
double[] numbers = { 1.2, 3.4, 5.6 };
double result2 = multiplier.Multiply(numbers);
Console.WriteLine($"Sonuç (dizi): {result2}");

Multiplier.SayHi("Mehmet");

Console.WriteLine(multiplier.Multiply(numbers));

// Fonksiyonları bir sınıf içinde tanımlayın

