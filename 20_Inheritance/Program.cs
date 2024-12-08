// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Car car = new Car(250);
Console.WriteLine(car.speed);
Console.WriteLine(car.wheels);
car.Go();

Bicycle bicycle = new Bicycle(40);
Console.WriteLine(bicycle.speed);
Console.WriteLine(bicycle.wheels);
bicycle.Go();






class Vehicle(int speed)
{
    public int speed = speed;

    public void Go(){
        Console.WriteLine("This vehicle goes");
    }
}

class Car(int speed) : Vehicle(speed){
    public int wheels = 4;
}

class Bicycle(int speed) : Vehicle(speed){
    public int wheels = 2;
}