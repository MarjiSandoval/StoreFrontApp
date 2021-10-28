using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            //2
            switch (inputName)
            {
                //3
                case "fred": //Same as checking if (inputName == "fred")
                    Console.WriteLine("Hey, Fred, Let's go golfing.");
                    
                    //4
                    break;
                case "karl": //Same as checking if (inputName == "karl")
                    Console.WriteLine("Let's hang.");
                    break;
                case "john":  //Same as checking if (inputName == "john")
                    Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default: //Same as else
                    Console.WriteLine("Hey, " + inputName + ", can I call you back in a minute?");
                    break;

            }
            //5
            //1
            Console.WriteLine("What's your name?");
            string friend = Console.ReadLine().ToLower();

            //2
            switch (friend)
            {
                //3
                case "andi": 
                    Console.WriteLine("Andi is a great friend.");

                    //4
                    break;
                case "ellen": 
                    Console.WriteLine("Dedicated to everything and everyone, sometimes to a fault.");
                    break;
                case "heidi":
                    Console.WriteLine("My sister from another mother.");
                    break;
                default: //Same as else
                    Console.WriteLine($"I'm sorry but I don't know {friend}");
                    break;
            }
        }
    }
}
