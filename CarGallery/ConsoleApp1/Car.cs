using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        // Fields
        private string _carname;
        private string _carmodel;
        private int _carprice;

        // Properties
        public string Carname
        {
            get { return _carname; }
            set { _carname = value; }
        }

        public string Carmodel
        {
            get { return _carmodel; }
            set { _carmodel = value; }
        }

        public int Carprice
        {
            get { return _carprice; }
            set { _carprice = value; }
        }

        public void Cars(string _carname)
        {
            if (_carname == "Audi")
            {
                AudiCars();
            }
        }

        public void AudiCars()
        {
            Console.WriteLine("Avaliable Audi Cars:");
            Console.WriteLine("1 - RS6");
            Console.WriteLine("2 - RS7");
            Console.WriteLine("3 - A8");
        }

        public void MercedesCars()
        {
            
        }

        public void BmwCars()
        {
            
        }

        public void PorcheCars()
        {
            
        }

    }
}
