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
            // 1. Simple Decision structure IF statement

            // can you it to determine two types of decision and have a different output based on input
            // if its true, then the next line of code runs, otherwise it skips to the next line of code after the if statement
            // Real world example is checking if someone is old enough to vote.
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a minor");
            }

            // 2. Multiple Decision structure IF-ELSE IF statement
            Console.WriteLine("Please enter a temprature");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("It is freezing outside");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("It is cold outside");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("It is cool outside");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("It is warm outside");
            }
            else
            {
                Console.WriteLine("It is hot outside");
            }


            // 3. Structured mutliple decision structure switch statement

            // a switch statement is much easier to read and understand than a long if-else statement

            // a main menu navigation system is a good example of a switch statement
            Console.WriteLine("Please select an option from the menu");
            Console.WriteLine("1. Play the game");
            Console.WriteLine("2. Settings");
            Console.WriteLine("3. Leaderboard");
            Console.WriteLine("4. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You have selected to play the game");
                    break;
                case "2":
                    Console.WriteLine("You have selected settings");
                    break;
                case "3":
                    Console.WriteLine("You have selected leaderboard");
                    break;
                case "4":
                    Console.WriteLine("You have selected exit");
                    break;
            }


            // 4. Complex and Nested Decision Logic

            // Allows your program to have more logic
            // This would give you more options, see all contraints and make more complex decisions
            // It can be used to check if you have money left in the bank

            bool hasMoney = true;
            int bankBalance = 1000;
            if (hasMoney)
            {
                if (bankBalance > 0)
                {
                    Console.WriteLine("You have money in the bank");
                }
                else
                {
                    Console.WriteLine("You have no money in the bank");
                }
            }
            else
            {
                Console.WriteLine("You have no money");

            }
        }
    }
}
