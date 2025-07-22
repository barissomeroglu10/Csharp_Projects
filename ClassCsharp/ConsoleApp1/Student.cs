using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Student class
    internal class Student
    {
        public string Name;
        public string Surname;
        public byte Exam1;
        public byte Exam2;

        // Student's information
        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAvarage: {Average()}");
        }

        // Calculate average
        public string Average()
        {
            return Convert.ToString(Convert.ToSingle(Exam1 * 0.4) + Convert.ToSingle(Exam2 * 0.6));
        }
    }
}
