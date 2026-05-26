using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        // store all the roomates, amounts and categories into lists
        // we do store this in lists, so that there can be an infinite amount 
        static List<string> transaction_roommates = new List<string>();
        static List<double> transaction_amounts = new List<double>();
        static List<string> transaction_categories = new List<string>();
        static List<string> roommates = new List<string>();

        //pre populate the categories
        static string[] categories = { "Food", "Rent", "Transport", "Other" };

       

        static void Main(string[] args)
        {
            bool program_is_on = true;

            while (program_is_on)
            {
                DisplayMenu();
                int user_Input = Convert.ToInt32(Console.ReadLine());

                switch (user_Input)
                {
                    case 1:
                        RecordTransaction();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(GetGroupSpending());
                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        ManageRoommates();
                        break;
                    case 4:
                        program_is_on = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        Console.ReadKey();
                        break;
                }
            }
        }


        // --- Displays Main Menu ---

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Group 8 Milestone Project\n");
            Console.WriteLine("---Main Menu---\n");
            Console.WriteLine("1. Record an Income or Expense");
            Console.WriteLine("2. Group Spending Habits");
            Console.WriteLine("3. Manage Roommates");
            Console.WriteLine("4. Exit");
            Console.Write("\nUser Input: ");
        }

        // --- Record Transaction ---

        static void RecordTransaction()
        {
            Console.Clear();
            Console.WriteLine("---Record Income / Expense---\n");

            // validation to check if there is a roomate
            if (roommates.Count == 0)
            {
                Console.WriteLine("No roommates added yet. Please add a roommate first.");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                return; //would skip the rest of the code if roomate count = 0
            }

            Console.WriteLine("Select a roommate:");
            // Function to display all the roomates
            Console.WriteLine(GetRoommateList());
            Console.Write("Enter number: ");
            int roommate_index = Convert.ToInt32(Console.ReadLine()) - 1;

            // validation to check if the user entered a valid input.
            if (roommate_index < 0 || roommate_index >= roommates.Count)
            {
                Console.WriteLine("Invalid selection.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nSelect a category:");
            // call the function to get a category
            Console.WriteLine(GetCategoryList());
            Console.Write("Enter number: ");
            int category_index = Convert.ToInt32(Console.ReadLine()) - 1;

            // validation to check for correct input.
            if (category_index < 0 || category_index >= categories.Length)
            {
                Console.WriteLine("Invalid selection.");
                Console.ReadKey();
                return;
            }

            // Get the amount input
            Console.Write("\nEnter an amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            AddTransaction(roommates[roommate_index], amount, categories[category_index]);

            string type;

            if (amount < 0)
            {
                type = "Expense";
            }
            else
            {
                type = "Income";
            }
            // Math.Abs does remove the minus of amount so that expenses : R-45 becomes expenses R45
            Console.WriteLine($"\n{type} of R{Math.Abs(amount)} recorded for {roommates[roommate_index]} under {categories[category_index]}.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void AddTransaction(string roommate, double amount, string category)
        {
            transaction_roommates.Add(roommate);
            transaction_amounts.Add(amount);
            transaction_categories.Add(category);
        }

        // --- Group Spending ---

        static string GetGroupSpending()
        {
            //validation to check if there are no transactions
            if (transaction_amounts.Count == 0)
            {
                return "No transactions recorded yet.";
            }

            string result = "---Group Spending Habits---\n\n";

            // run with a for loop through all the categories
            for (int i = 0; i < categories.Length; i++)
            {
                double total = GetCategoryTotal(categories[i]);
                result += $"{categories[i]}: R{total}\n";
            }

            result += $"\nTotal Income:   R{GetTotalIncome()}";
            result += $"\nTotal Expenses: R{GetTotalExpenses()}";
            result += $"\nNet Balance:    R{GetNetBalance()}";

            //create on big string with \n's so that we can return it into main function
            return result;
        }

        static double GetCategoryTotal(string category)
        {
            double total = 0;
            for (int i = 0; i < transaction_categories.Count; i++)
            {
                if (transaction_categories[i] == category)
                {
                    total += transaction_amounts[i];
                }
            }
            return total;
        }

        static double GetTotalIncome()
        {
            double total = 0;
            for (int i = 0; i < transaction_amounts.Count; i++)
            {
                if (transaction_amounts[i] > 0) total += transaction_amounts[i];
            }
            return total;
        }

        static double GetTotalExpenses()
        {
            double total = 0;
            for (int i = 0; i < transaction_amounts.Count; i++)
            {
                if (transaction_amounts[i] < 0) total += transaction_amounts[i];
            }
            return total;
        }

        static double GetNetBalance()
        {
            double total = 0;
            for (int i = 0; i < transaction_amounts.Count; i++)
            {
                total += transaction_amounts[i];
            }
            return total;
        }

        // --- Manage Roommates ---

        static void ManageRoommates()
        {
            bool in_menu = true;

            while (in_menu)
            {
                Console.Clear();
                Console.WriteLine("---Manage Roommates---\n");
                Console.WriteLine("1. Add Roommate");
                Console.WriteLine("2. View Roommates");
                Console.WriteLine("3. Back");
                Console.Write("\nUser Input: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter roommate name: ");
                        string name = Console.ReadLine();
                        roommates.Add(name);
                        Console.WriteLine($"{name} added.");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("---Roommates---\n");
                        Console.WriteLine(GetRoommateList());
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        in_menu = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        Console.ReadKey();
                        break;
                }
            }
        }

        

        static string GetRoommateList()
        {
            if (roommates.Count == 0) return "No roommates added.";

            string result = "";
            for (int i = 0; i < roommates.Count; i++)
            {
                result += $"{i + 1}. {roommates[i]}\n";
            }
            return result;
        }

        static string GetCategoryList()
        {
            string result = "";
            for (int i = 0; i < categories.Length; i++)
            {
                result += $"{i + 1}. {categories[i]}\n";
            }
            return result;
        }
    }
}
