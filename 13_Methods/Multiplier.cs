class Multiplier
{
    // İki double değeri çarpan metot
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Bir double dizisini çarpan metot
    public double Multiply(params double[] numbers)
    {
        double result = 1;
        foreach (var number in numbers)
        {
            result *= number;
        }
        return result;
    }

    public double Multiply(params int[] numbers)
    {
        double result = 1;
        foreach(int num in numbers)
        {
            result *= num;
        }

        return result;
    }

    public static void SayHi(string name){
        Console.WriteLine("Merhaba: " + name);
    }
}