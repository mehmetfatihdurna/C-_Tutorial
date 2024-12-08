// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");

String[] ford = {"Mustang", "F-150", "Explorer"};
String[] chevy = {"Corvette", "Camaro", "Silverado"};
String[] toyota = {"Coralla", "Camry", "Rav4"};

String[,] parking = {{"Mustang", "F-150", "Explorer"},
                     {"Corvette", "Camaro", "Silverado"},
                     {"Coralla", "Camry", "Rav4"}};


foreach(String item in parking){
    Console.WriteLine(item);
}

for(int i = 0; i<parking.GetLength(0); i++){
    for(int j = 0; j<parking.GetLength(1); j++){
        Console.Write(parking[i,j] + " ");
    }
}
