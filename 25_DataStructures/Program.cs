// See https://aka.ms/new-console-template for more information


List<String> strings = [];

strings.Add("Pizza");
strings.Add("Apple");
strings.Add("Brocoli");


foreach(String str in strings){
    Console.WriteLine(str);
}

strings.Insert(0,"Patato");
strings.Insert(0,"Patato");
strings.Remove("Pizza");

Console.WriteLine(strings.Count);

foreach(String str in strings){
    Console.WriteLine(str);
}

Console.WriteLine(strings.Contains("Apple"));

Console.WriteLine(strings.IndexOf("Apple"));

strings.Reverse();

foreach(String str in strings){
    Console.Write(str + " ");
}



List<Person> persons = [];
Person person1 = new("Ahmet");
Person person2 = new("Mehmet");
Person person3 = new("Fatma");

persons.Add(person1);
persons.Add(person2);
persons.Add(person3);

Console.WriteLine();
foreach(Person person in persons){
    Console.WriteLine(person.name);
}




class Person(String name){
    public String name = name;
}