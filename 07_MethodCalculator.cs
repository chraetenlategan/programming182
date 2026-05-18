using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG182_hello_world
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // All displayment information
            Console.WriteLine("Welcome to Chraeten's Calculator using methods");
            bool program_is_on = true;
            while (program_is_on)
                {

                    DisplayMenu();

                    //Get user input
                    string user_input = Console.ReadLine();
                    Console.WriteLine("Please enter your first number");
                    double inum1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter your second number");
                    double inum2 = Convert.ToDouble(Console.ReadLine());

                    switch (user_input)
                    {
                        case "1":
                            // addition
                            Console.WriteLine($" {inum1} + {inum2} = {Addition(inum1, inum2)}");
                            break;
                        case "2":
                            //subtraction
                            Console.WriteLine($" {inum1} - {inum2} = {Subtraction(inum1, inum2)}");
                            break;
                        case "3":
                            //division
                            Console.WriteLine($" {inum1} / {inum2} = {Division(inum1, inum2)}");
                            break;
                        case "4":
                            //multiplication
                            Console.WriteLine($" {inum1} * {inum2} = {Multiplication(inum1, inum2)}");
                            break;
                        case "5":
                            Console.WriteLine("Thank you for using my calculator");
                            program_is_on = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }

                    Console.ReadKey();

                }
            
            }
        public static void DisplayMenu()
        {
            Console.WriteLine("Press 1 for addition");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for division");
            Console.WriteLine("Press 4 for multiplication");
            Console.WriteLine("Press 5 to Exit");


        }

        public static double Addition(double num1, double num2)
        {
            return (num1 + num2); 
        }

        public static double Subtraction(double num1, double num2)
        {
            return (num1 - num2);
        }

        public static double Multiplication(double num1, double num2)
        {
            return (num1 * num2);
        }

        public static double Division(double num1, double num2)
        { 
           return (num1 / num2);
        }
    }


}


