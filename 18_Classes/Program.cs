// See https://aka.ms/new-console-template for more information

using _18_Classes;

Human human1 = new Human("Mehmet Fatih", 20);


Messages.SayHi(human1.GetName());

human1.Eat();
human1.Sleep();

Car.GetNumberOfCars();

Car car1 = new Car("Toyota");
Car car2 = new Car("BMW");

Car.GetNumberOfCars();
