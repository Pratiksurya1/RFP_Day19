using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Demo
{
    internal class Program
    {
       static bool flag;
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
                    String FName = Console.ReadLine();

                    bool flag = patternCheck.FirstName(FName);
                    if (flag)
                        Console.WriteLine("Valid Name");
                    else
                        Console.WriteLine("InValid Name");
                    break;

                case 2:
                    Console.WriteLine("Enter the Last Name: ");
                    string LName = Console.ReadLine();

                    flag = patternCheck.FirstName(LName);
                    if (flag)
                        Console.WriteLine("Valid Name");
                    else
                        Console.WriteLine("InValid Name");
                    break;

                case 3:
                    Console.WriteLine("Enter the Mail ID : ");
                    string MailID = Console.ReadLine();

                    flag = patternCheck.FirstName(MailID);
                    if (flag)
                        Console.WriteLine("Valid Name");
                    else
                        Console.WriteLine("InValid Name");
                    break;

                case 4:
                    Console.WriteLine("Enter the Mo. Number : ");
                    string mNum = Console.ReadLine();

                    flag = patternCheck.FirstName(mNum);
                    if (flag)
                        Console.WriteLine("Valid Name");
                    else
                        Console.WriteLine("InValid Name");
                    break;


                case 5:
                    Console.WriteLine("Enter the Password : ");
                    string Pass = Console.ReadLine();

                    flag = patternCheck.FirstName(Pass);
                    if (flag)
                        Console.WriteLine("Valid Name");
                    else
                        Console.WriteLine("InValid Name");
                    break;


            }



        }
    }
}
