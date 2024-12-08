// See https://aka.ms/new-console-template for more information









Car car = new Car(250);

Console.WriteLine($"The speed is {car.Speed} and acceleration value is {car.Accelerate}");

car.Accelerate = 2;

Console.WriteLine($"The speed is {car.Speed} and acceleration value is {car.Accelerate}");









class Car(int speed){
    private int speed = speed;
    private int acceleration = 1;

    public int Speed{
        get{return speed;}
        set{speed = value;}
    }

    public int Accelerate{
        set{speed *= value;acceleration=value;}
        get{return acceleration;}
    }
}
