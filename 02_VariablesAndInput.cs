5/11/2026
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG182_hello_world
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string name;
            name = "Chraeten";
            int age;
            age = 18;
            // Its my Birthday today
            age = age + 1;
            string city;
            Console.WriteLine("What city are you from");
            city = Console.ReadLine();
            //Calculations
            int days_alive;
            days_alive = age * 365;

            Console.WriteLine($"Hello I am {name} and I am {age} years old and {days_alive} and I am from {city}");
            Console.ReadKey();
        }
    }
}
