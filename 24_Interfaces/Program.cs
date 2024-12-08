// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Rabbit rabbit = new Rabbit();
rabbit.Flee();

Hawk hawk = new Hawk();
hawk.Hunt();

Fish fish = new Fish();
fish.Flee();
fish.Hunt();


interface IPrey{
    void Flee(){}
}
interface IPredator{
    void Hunt(){}
}

class Rabbit : IPrey{
    public void Flee(){
        Console.WriteLine("The rabbit runs away!");
    }
}

class Hawk : IPredator{
    public void Hunt(){
        Console.WriteLine("The Hawk is searching for the food.");
    }
}

class Fish: IPrey,IPredator{
    public void Hunt(){
        Console.WriteLine("The Fish is searching smaller fish to eat.");
    }

    public void Flee(){
        Console.WriteLine("The Fish runs away.");
    }
}