using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Car classs
    internal class Car
    {
        public string Brand;
        public string Model;
        public string MadeYear;

        // Car's information
        public void ShowInformations()
        {
            Console.WriteLine($"Brand: {Brand}\nModel: {Model}\nMade Year: {MadeYear}");
        }
    }
}
