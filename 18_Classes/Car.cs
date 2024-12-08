using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Classes
{
    public class Car
    {
        private static int carCounter; //static diyerek oluşturulan değişkeni, car sınıfından türetilen ogjelerden bağımsız olarak kullanabiliyoruz.
        public String model;
        

        public Car(String model){
            carCounter++;
            this.model = model;
        }

        public static void GetNumberOfCars(){
            Console.WriteLine(carCounter);
        }
    }
}