using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double[] imarks = new double[5];
            Console.WriteLine("Welcome to Chraeten's average calculator");
            double total_marks = 0;

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter your mark for studnet {i+1}");
                imarks[i] =Convert.ToDouble( Console.ReadLine());
                total_marks += imarks[i];

            }

            Console.WriteLine($"The average is {total_marks/imarks.Length}");



            Console.ReadKey();
           
    
        }
       

        
    }
}
