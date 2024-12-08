// See https://aka.ms/new-console-template for more information



/*
int counter = 0;
while(1 == 1){
    ++counter;
    Console.WriteLine(counter);
}
*/

String name = "";

while(name == ""){
    Console.WriteLine("Enter your name: ");
    name = Console.ReadLine();
}

Console.WriteLine("Hello " + name);

Console.Write("Spelling of your name: ");
for(int i = 0; i<name.Length; i++){ //i+=2 2'şer arttırır
    Console.Write(name[i] + " - ");
}
Console.WriteLine();


String[] names = {"Ahmet", "Mehmet", "Ali", "Fatma"};


//Foreach Loop
foreach (String item in names)
{
    Console.WriteLine(item + " ");
}


