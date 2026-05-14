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
            // Main menu driven shown how loops work

            string user_input = "";
            do
            {
                DisplayMenu();
                user_input = Console.ReadLine();

            } 
            while (user_input != "4");
                
            // Display menu
       
           
            switch (user_input)
            {
                case "1":
                    {
                        // Display Hello world as much as your Input
                        Console.WriteLine("Please enter a number:");
                        int inum = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < inum; i++)
                        {
                            Console.WriteLine($"Hello world {i}");
                        }
                    }
                    break;

                case "2":
                    {
                        // Enter a number and count down until 0
                        Console.WriteLine("Please enter a number:");
                        int jnum = Convert.ToInt32(Console.ReadLine());
                        for (int j = 1; j > jnum; j--)
                        {
                            Console.WriteLine($"Countdown {j}");

                        }
                    }
                    break;
                case "3":
                    // Enter marks to calculate average
                    {
                        Console.WriteLine("Enter your marks (enter -1 to finish):");
                        int user_mark = 0;
                        int sum = 0;
                        int count = 0;
                        while ((user_mark = Convert.ToInt32(Console.ReadLine())) != -1)
                        {
                            sum = sum + user_mark;
                            count++;
                        }
                        Console.WriteLine($"The average of your marks is: {sum/count}");
                    }
                    break;
                case "4":
                    // Exit
                    Console.WriteLine("Exiting the program...");
                    break;
            }

        }
        static void DisplayMenu()
        {
            Console.WriteLine("Please enter your choice:");
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Display Hello world as much as your Input");
            Console.WriteLine("2. Enter a number and count down until 0");
            Console.WriteLine("3. Enter marks to calculate average");
            Console.WriteLine("4. Exit");
        }
    }
}
