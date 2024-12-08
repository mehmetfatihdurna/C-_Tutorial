using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _19_OverLoadedConstructors
{
    public class Pizza
    {
        public String bread,souce,cheese;
        public String? topping; // topping ifadesinin boş bırakılabileceğini belirtmek için String? ifadesini kullandım


        public Pizza(String bread, String souce, String cheese){
            this.bread = bread;
            this.souce = souce;
            this.cheese = cheese;
        }

        public Pizza(String bread, String souce, String cheese, String topping){
            this.bread = bread;
            this.souce = souce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public void Print(){
            Console.WriteLine($"{this.bread} {this.souce} {this.cheese} {this.topping}");
        }
        
    }
}