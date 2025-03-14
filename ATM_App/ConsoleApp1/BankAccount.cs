using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        private string _username;
        private int _balance;

        public BankAccount(string UserName, int Balance)
        {
            _username = UserName;
            _balance = Balance;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your Account's Balance is {_balance}");
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                _balance += amount;

                Console.WriteLine($"{amount} TL is deposited");

                ShowBalance();
            }

            else
            {
                Console.WriteLine("Please Enter a Valid Number!");
            }
        }

        public void Withdraw(int amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;

                Console.WriteLine($"You withdraw {amount} TL");

                ShowBalance();
            }

            else if (amount <= 0)
            {
                Console.WriteLine("Please Enter a Valid Number");
            }

            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
    }
}
