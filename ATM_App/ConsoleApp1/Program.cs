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
            string Password = "1234";
            int TryRight = 3;

            Console.Write("Enter Password:");
            string EnteredPassword = Console.ReadLine();

            while (TryRight > 0)
            {
                if (EnteredPassword == Password)
                {
                    Console.WriteLine("Succesfully Login!");
                    break;
                }

                else
                {
                    TryRight--;

                    Console.WriteLine("Entered Password isn't Correct!");

                    Console.WriteLine($"You have last {TryRight} try!");

                    if (TryRight <= 0)
                    {
                        Console.WriteLine("Your account is suspended!");

                        return;
                    }
                }
            }

            Console.Write("Enter Your Name: ");
            string UserName = Console.ReadLine();

            Console.Write("Enter your balance:");
            int Balance = Convert.ToInt32(Console.ReadLine());

            bool a = true;

            while (a)
            {
                Console.WriteLine("\t\t\t\t ATM MENU");

                Console.WriteLine("1- Show Balance\n2- Deposit Money\n3- Withdraw Money\n4- Exit");

                Console.Write("Please Enter Menu Number:");

                int MenuNumber = Convert.ToInt32(Console.ReadLine());

                switch(MenuNumber)
                {
                    
                }
            }

            Console.ReadKey();
        }
    }
}
