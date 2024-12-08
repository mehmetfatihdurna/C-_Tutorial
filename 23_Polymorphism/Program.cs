// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Car car = new Car();
Bicycle bicycle = new Bicycle();
Boat boat = new Boat();


Vehicle[] vehicles = {car,bicycle,boat};

foreach(Vehicle vehicle in vehicles){
    vehicle.Go();
}




abstract class Vehicle{

    public virtual void Go(){}
}

class Car : Vehicle{
    public override void Go()
    {
        Console.WriteLine("The Car goes.");
    }
}

class Bicycle : Vehicle{
    public override void Go()
    {
        Console.WriteLine("The Bicycle goes.");
    }
}

class Boat : Vehicle{
    public override void Go()
    {
        Console.WriteLine("The Boat goes.");
    }
}