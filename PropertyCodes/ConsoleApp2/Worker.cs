using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Worker
    {
        private double _salary = 0.0d;
        private double minSalary = 5000;
        public double _Salary
        {
            get { return _salary; }

            set
            {
                if (value >= minSalary)
                {
                    _salary = value;
                }

                else
                {
                    Console.WriteLine($"Wrong Amount! Minimum Salary is {minSalary}");
                }
            }
        }
    }
}
