using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            // runs the program until the user exits and set bool to false.
            Boolean programIsON = true;
        // Store data in 3 parallel 1D arrays of the size of 5
        string[] cadet_names = new string[5];
        string[] cadet_ID = new string[5];
        int[] simulation_score = new int[5];

            while (programIsON)
            {
                //Display all the menu types.
                Console.WriteLine("=== BC CYBRESHIELD DIVISION SYSTEM ===\n");
                Console.WriteLine("1. Register Cadet");
                Console.WriteLine("2. View all Cadets");
                Console.WriteLine("3. Count Cleared Cadets");
                Console.WriteLine("4. Display Elite Cadet");
                Console.WriteLine("5. Search Cadet by name");
                Console.WriteLine("6. Exit system");

                Console.WriteLine("Please do enter number : \t");
                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        {
                            Console.WriteLine("Please do enter the cadets name: ");
                            string user_cadet_name = Console.ReadLine();
                            Console.WriteLine("Please do enter the Cadets ID: ");
                            string user_cadet_ID = Console.ReadLine();
                            Console.WriteLine("Please do enter the Cadets simulation score ");
                            int user_simulation_score = Convert.ToInt32(Console.ReadLine());

                            RegisterCadet(user_cadet_ID, user_cadet_name, user_simulation_score, simulation_score,cadet_ID,cadet_names);
                            break;
                        }
                    case "2":
                        {
                            ViewAllCadets(simulation_score, cadet_names, cadet_ID);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine($"The amount of cleared cadets are: {CountCleared(simulation_score)}");
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("Please do enter the Cadet's name: ");
                            string name_entered = Console.ReadLine();
                            if (SearchCadets(cadet_names,name_entered) == -1)
                            {
                                Console.WriteLine("This name does not exists");
                            }
                            else
                            {
                                int index = SearchCadets(cadet_names, name_entered);
                                Console.WriteLine("Match found");
                                Console.WriteLine($"ID: {cadet_ID[index]} | Name: {cadet_names[index]} | Score: {simulation_score[index]}");
                            }


                                break;  
                        }
                    case "4":
                        {
                            DisplayEliteCadet(simulation_score,cadet_names,cadet_ID);
                            break;
                        }
                    case "6":
                        {
                            
                            programIsON = false;
                            Console.WriteLine("Thanks for using this program");
                            Environment.Exit(0);
                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Please do enter a valid number");
                            break;
                        }
                }




            }
        }

        static void RegisterCadet(string cadet_id, string cadet_name, int simmulation_score, int[] arr_simmulation_score, string[] arr_cadetID, string[] arr_cadet_names)
        {
            int index_found = -1;
            // first check if there is any space in the array to append
            Boolean space_found = false;
            for (int j = 0; j < arr_cadetID.Length; j++)
            {
                if (arr_simmulation_score[j] == 0)
                {
                    space_found = true;
                    // we store this index so we know where to save to now.
                    index_found = j;
                }
            }

            if (space_found != true)
            {
                Console.WriteLine("There was not enough space in array.");
            }

            else
            {
                // then we begin to check our other conditions.

                // check if ID exists
                Boolean id_found = false;
                for (int i = 0; i > arr_cadetID.Length; i++)
                {
                    if (cadet_id == arr_cadetID[i])
                    {
                        id_found = true;
                        

                    }
                }

                // if the ID is not found we can do the next check
                // if it is a valid score.
                if (simmulation_score < 0 || simmulation_score > 100)
                {
                    Console.WriteLine("Please do enter a valid score between 0 and 100");
                }

                else if (id_found)
                {
                    Console.WriteLine("This ID already exists.");
                }
                else
                {
                    //now it passed all the check we can add it into the array.
                    arr_simmulation_score[index_found] = simmulation_score;
                    arr_cadet_names[index_found] = cadet_name;
                    arr_cadetID[index_found] = cadet_id;
                    Console.WriteLine("The cadet have been sucsesfully added.");

                }


            }
             
        }

        static void ViewAllCadets(int[] arrsimulationscore, string[] arrcadetnames, string[] arrcadetID)
        {
            for (int i = 0;i < arrcadetnames.Length;i++)
            {
                //Does not Displat empty values.
                if (arrsimulationscore[i] != 0)
                {
                Console.WriteLine($"ID: {arrcadetID[i]} | Name: {arrcadetnames[i]} | Score: {arrsimulationscore[i]}");

                }
            }
        }
        static int CountCleared(int[] arrsimulationscore)
        {
            int icount = 0;

            for (int i = 0; i < arrsimulationscore.Length; i++)
            {
                if (arrsimulationscore[i] >= 50)
                {
                    icount++;
                }
            }
            return icount;
        }

        static int SearchCadets(string[] cadetsnames, string name_entered)
        {
            int index = -1;
            // so the loop finds the index where the names are the same and returns this index
            // if the index would be -1 it would mean that the name was not found

            for (int i = 0; i < cadetsnames.Length; i++)
            {
                if (name_entered == cadetsnames[i])
                {
                    index = i;
                }
            }

                return index;
        }

        static void DisplayEliteCadet(int[] simulation_score, string[] cadetsname, string[] cadetID)
        {
            int highest_score = 0;
            int index = -1;
            for (int i = 0; i < simulation_score.Length; i++)
            {
                if (simulation_score[i] >  highest_score)
                {
                    highest_score = simulation_score[i];
                    index = i;
                }
            }
            if (index != -1)
            {
                Console.WriteLine("=== ELITE CADET DETECTED ===");
                Console.WriteLine($"ID : {cadetID[index]}");
                Console.WriteLine($"Name :{cadetsname[index]}");
                Console.WriteLine($"Score : {simulation_score[index]}");

            }
            else
            {
                Console.WriteLine("There was no elite cadet.");
            }

        }
    }
}
