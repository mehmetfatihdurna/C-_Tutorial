// See https://aka.ms/new-console-template for more information



Dog dog = new Dog("Tony",5);

Cat cat = new Cat("Miss",2);

dog.Speak();
cat.Speak();

Console.WriteLine(dog.ToString());
Console.WriteLine(cat.ToString());


Console.ReadKey();


abstract class Animal(String name, int age){
    public String name = name;
    public int age = age;
    public virtual void Speak(){}
}


class Dog(String name, int age) : Animal(name, age){
    private readonly static String type = "Dog";
    public override void Speak()
    {
        Console.WriteLine("The dog goes \"woof!\"");
    }

    public override string ToString()
    {
        String str = $"Type: {type}\nName: {this.name}\nAge: {this.age}";
        return str;
    }
}


class Cat(String name, int age) : Animal(name, age){
    private readonly String type = "Cat";
    public override void Speak()
    {
        Console.WriteLine("The cat goes \"mrr!\"");
    }

    public override string ToString()
    {
        String str = $"Type: {type}\nName: {this.name}\nAge: {this.age}";
        return str;
    }
}