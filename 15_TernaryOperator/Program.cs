// See https://aka.ms/new-console-template for more information


while(true){
    Console.Write("What is weather temparature: ");
    int temparature = Convert.ToInt32(Console.ReadLine());
    String message;

    /*
    if(temparature < 20){
        message = "It is cold outside";
    }else{
        message = "It is warm outside";
    }
    */

    message = (temparature < 20) ? "It is cold outside" : "It is warm outside";

    Console.WriteLine(message);
}