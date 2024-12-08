// See https://aka.ms/new-console-template for more information


//String[] cars = {"BMW", "MERCEDES","RENAULT"};

String[] cars = new string[3]; //arraylar belirli sayıda eleman tutması için ayarlanabilir.

cars[0] = "BMW";
cars[1] = "RENAULT";
cars[2] = "BROADWAY";



//Console.WriteLine(cars[0] + " " + cars[1] + " " + cars[2]);

for(int i = 0; i < cars.Length; i++){
    Console.Write(cars[i] + " ");
}