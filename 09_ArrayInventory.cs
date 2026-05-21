using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] inventory = new string[10];
            int[] quantity = new int[10];

            bool program_is_on = true;

            while (program_is_on)
            {
                DisplayMenu();
                int user_input = Convert.ToInt32(Console.ReadLine());

                switch (user_input)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter an item");
                            string inventory_item = Console.ReadLine();
                            Console.WriteLine("Please enter an amount");
                            int inventory_amount = Convert.ToInt32( Console.ReadLine());
                            AddAnItem(inventory, quantity,inventory_amount, inventory_item);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(ViewInventory(inventory,quantity));
                            break ;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please enter an Index you would like to change");
                            int user_index_entered = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter the amount");
                            int user_amount_entered = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(UpdateBalance(quantity, user_index_entered, user_amount_entered, inventory));
                            break ;
                        }
                    case 4:
                        {
                            program_is_on = false;
                            break ;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter a valid value");
                            break;
                        }
                }

            }
        }
        static void  DisplayMenu()
        {
            Console.WriteLine("---Inventory System---");
            Console.WriteLine("1. Add an Item");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Update quantity");
            Console.WriteLine("4. Exit");
        }

        static void AddAnItem(string[] inven, int[] amounts, int user_amount_input, string user_inven_input)
        {
            bool found_open_space = false;
            int icount = 0;

            while (found_open_space == false && icount < inven.Length)
            {
                if (inven[icount] == null)
                {
                    amounts[icount] = user_amount_input;
                    inven[icount] = user_inven_input;
                    found_open_space=true;
                }

                else
                {
                    icount++;
                }
            }
            if (found_open_space == false)
            {
                Console.WriteLine("There is not enough space in inventory");
            }
        }

        static string ViewInventory(string[] invertory, int[] iquantity)
        {
            string build = "";
            for (int i = 0; i<invertory.Length; i++)
            {
                if (invertory[i] != null)
                {
                    build += $"{invertory[i]} : {iquantity[i]} \n" ;
                }
            }
            return build;
        }

        static string UpdateBalance(int[] quantities, int user_index, int user_amount, string[] inven)
        {
            quantities[user_index] += user_amount;
            return $"{inven[user_index]} : {quantities[user_index]}";
        }
    }
}
