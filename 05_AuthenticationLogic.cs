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
            // The username and password hardcoded in the program
            string username = "admin";
            string password = "admin123";


            Console.WriteLine("Please enter a Username");
            string s_username = Console.ReadLine();

            Console.WriteLine("Please enter a Password");
            string s_password = Console.ReadLine();

            if (s_username == username && s_password == password)
            {
                Console.WriteLine("Welcome, " + s_username + "!");
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
            }


        }
    }
}
