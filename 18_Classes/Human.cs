using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Classes
{
    class Human(String name, int age)
    {
        private String name = name;
        private int age = age;

        /*
        Classlarda bu şekilde constructor da tanımlanabilmektedir.
        public Human(String name, int age){
            this.name = name;
            this.age = age;
        }
        */

        public void Eat(){
            Console.WriteLine(name + " is eating");
        }

        public void Sleep(){
            Console.WriteLine(name + " is sleeping");
        }

        public String GetName(){
            return this.name;
        }

        public int GetAge(){
            return this.age;
        }

        public void SetName(String name){
            this.name = name;
        }

        public void SetAge(int age){
            this.age = age;
        }
    }
}