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
            // Implicit conversion from int to double
            Console.WriteLine("Implicit conversion");
            int students = 10;
            double numberofstudents = students;
            Console.WriteLine($"The integer number of students: {students}");
            Console.WriteLine($"The double number of students: {numberofstudents}");


            // Explicit conversion from double to int
            Console.WriteLine("Explicit conversion");
            double marks = 85.5;
            int roundedMarks = (int)marks;
            Console.WriteLine($"The double marks: {marks}");
            Console.WriteLine($"The rounded integer marks: {roundedMarks}");

            Console.ReadKey();


            // promt the user to enter there full name
            Console.WriteLine("Please to enter your full name");
             string susername = Console.ReadLine();
            
            // promt the user to enter there cellphone number
            Console.WriteLine("Please enter your cellphone number");
            string cellphone_num = Console.ReadLine();

            // promt the user to enter there DOB
            Console.Write("Enter your year of birth: ");
            int birthyear = Convert.ToInt32(Console.ReadLine());

            // promt the user to enter there salary
            Console.WriteLine("Please enter your salary");
            double salary = Convert.ToDouble(Console.ReadLine());

            // Display fullname, cellphone number, DOB and salary net and gross 15% tax
            Console.WriteLine($"Full name: {susername}");
            Console.WriteLine($"Cellphone number: {cellphone_num}");
            Console.WriteLine($"Year of birth: {birthyear}");
            Console.WriteLine($"Sallary: {salary}");
            double net_sallary;
            net_sallary = salary;
            double gross;
            gross = salary - (salary * 0.15);
            Console.WriteLine($"Net Sallary: {net_sallary}");
            Console.WriteLine($"Gross Sallary: {gross}");








        }
    }
}
