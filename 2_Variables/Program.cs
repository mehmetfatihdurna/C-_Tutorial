// See https://aka.ms/new-console-template for more information



int x; //declaration
x = 123; //initialization

int y = 123;
int age = 20; // whole integer
Console.WriteLine(x);
Console.WriteLine(y);

double height = 190.5; // decimal Number
bool alive = true;
char symbol = '@';
String name = "Mehmet Fatih";

Console.WriteLine("My name is: " + name);
Console.WriteLine("My Age is: " + age);
Console.WriteLine("My Height is: " + height);
Console.WriteLine("Are you alive? " + alive);
Console.WriteLine("Your Symbol is: ", symbol);

// constants = immutable values which are known at compile time and do not change for the life of the program

const double PI = 3.1415;
Console.WriteLine("PI number is constant: " + PI);

//Type Casting = Converting a value to a different data type

int integer = Convert.ToInt32(PI); // Convert.ToDouble() ToString ToBoolean

Console.WriteLine("Integer: "+integer);
Console.WriteLine(integer.GetType());


Console.ReadKey();
