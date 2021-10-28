using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        private const decimal V = 0.58m;
        private const decimal V1 = 1.0M;

        static void Main(string[] args)
        {
            //Bronze//
            int age;
            string vehicleType;
            bool isRunning;
            double pie;
            float payRate;
            decimal d;
            String comfort = " is a comfortable ride.";

            int birthYear = 1974; //gold//
            string msg = "I was born in " + birthYear.ToString(); //gold//
            age = 47;
            vehicleType = "Freightliner Cascadia";
            isRunning = true;
            pie = 3.14;
            payRate = 13;
            Console.WriteLine(pie);
            Console.WriteLine(payRate);
            Console.WriteLine(vehicleType);
            Console.WriteLine(vehicleType + comfort); //Silver//
            Console.WriteLine(birthYear);
            Console.WriteLine(msg);
            Console.ReadLine();

         

            

            
            
        }   
            
    }
}
