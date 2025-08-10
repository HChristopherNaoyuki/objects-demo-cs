using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects_demo_cs
{
    public class Program
    {
        // Object
        // An intance of a class.
        // A class can be used as a blueprint to create objects.
        // NOTE: Object Oriented Programming (OOP).
        // Objects can have fields and methods.
        // NOTE: Characteristics and actions.

        static void Main(string[] args)
        {
            try
            {
                // Human
                Human human = new Human();
                human.Name = "James";
                human.Age = 30;
                human.Eat();
                human.Sleep();

                // Human 2
                Human human2 = new Human();
                human2.Name = "Johnny";
                human2.Age = 30;
                human2.Eat();
                human2.Sleep();
            }
            catch (Exception Issue)
            {
                // Exception Handling.
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }
    }

    public class Human
    {
        public String Name;
        public int Age;

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }
}
