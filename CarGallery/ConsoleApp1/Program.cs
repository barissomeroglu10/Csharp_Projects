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

            Console.WriteLine("\t\t\t\tWELCOME TO THE CAR SHOWROOM via Sezginler Otomotiv");
            Console.WriteLine("\nPlease Select Your Proccess");
            Console.WriteLine("\n1 - Buy a car");
            Console.WriteLine("2 - Search a car");

            Console.WriteLine("Please Press 1 or 2");
            int SelectedNumber = Convert.ToInt32(Console.ReadLine());

            if (SelectedNumber == 1)
            {
                Console.WriteLine("Whic Brand Do You Want to Buy?");
                string EnteredCarNames = Console.ReadLine();

                Car car1 = new Car();

                if (EnteredCarNames == "Audi")
                {
                    car1.Cars(EnteredCarNames);

                    Console.WriteLine("Please Select Your Car Model");
                    int SelectedCarModel = Convert.ToInt32(Console.ReadLine());
                }

                else if (EnteredCarNames == "Mercedes")
                {
                    
                }

                else if (EnteredCarNames == "BMW")
                {

                }

                else if (EnteredCarNames == "Porche")
                {

                }
            }

            else
            {
                
            }

            Console.ReadLine();
        }
    }
}
