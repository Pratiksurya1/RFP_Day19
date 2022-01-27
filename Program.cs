using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            PatternCheck patternCheck = new PatternCheck();

            Console.WriteLine("User Registration Validate using Regular Expression");
            Console.WriteLine("Choose Option to Execute the Regex Program: \n UC 1. Validate First Name");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the First Name: ");
                    string Name = Console.ReadLine();

                    bool value1 = patternCheck.FirstName(Name);
                    if (value1)
                        Console.WriteLine("Valid Name");
                    else
                        Console.WriteLine("InValid Name");
                    break;

            }



        }
    }
}
