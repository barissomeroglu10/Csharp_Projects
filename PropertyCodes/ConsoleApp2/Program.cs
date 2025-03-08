using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define variables
            double Salary = 0.0D;

            // get value from user
            Console.Write("Please Enter Your Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Worker w1 = new Worker();

            w1._Salary = Salary;

            Console.WriteLine($"Salary is {w1._Salary}");
        }
    }
}
