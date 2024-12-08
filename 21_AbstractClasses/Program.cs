// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Car car1 = new Car(250);

car1.Print();

Bicycle bicycle1 = new Bicycle(40);
bicycle1.Print();


abstract class Vehicle(int speed){
    public int speed = speed;
}

class Car(int speed) : Vehicle(speed){
    public readonly static int wheels = 4;
    public readonly static String type = "Car";

    public void Print(){
        Console.WriteLine($"It is a {type}. It has {wheels} wheels. It can be reach {this.speed}km/h.");
    }
}


class Bicycle(int speed) : Vehicle(speed){
    public readonly static int wheels = 2;
    public readonly static String type = "Bicycle";

    public void Print(){
        Console.WriteLine($"It is a {type}. It has {wheels} wheels. It can be reach {this.speed}km/h.");
    }
}