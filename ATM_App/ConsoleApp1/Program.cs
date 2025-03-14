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
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            string Password = "1234";
            int TryRight = 3;

            Console.Write("Enter Password: ");
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

            BankAccount b1 = new BankAccount(UserName, Balance);

            while (a)
            {
                Console.WriteLine("\t\t\t\t ATM MENU");

                Console.WriteLine("1- Show Balance\n2- Deposit Money\n3- Withdraw Money\n4- Exit");

                Console.Write("Please Enter Menu Number:");

                int MenuNumber = Convert.ToInt32(Console.ReadLine());

                switch(MenuNumber)
                {
                    case 1: b1.ShowBalance();
                        break;

                    case 2: Console.Write("Please Enter Deposit Ammount: ");
                        int DepositAmount = Convert.ToInt32(Console.ReadLine());

                        b1.Deposit(DepositAmount);
                        break;

                    case 3: Console.Write("Please Enter Withdraw Ammount: ");
                        int WithdrawAmount = Convert.ToInt32(Console.ReadLine());

                        b1.Withdraw(WithdrawAmount);
                        break;

                    case 4: Console.WriteLine("Closing the ATM");
                        a = false;
                        break;
                }
            }

            for (int i = 1; i <= 100; i++)
            {
                Console.Write($"App is closing %{i} \r"); // \r return the first line
                System.Threading.Thread.Sleep(40); // wait 40 ms
            }

            Console.ReadKey();
        }
    }
}
