#region Developer's Description
/*
Purpose of the code is learn object and class in C#

Developer: Barış Someroğlu
Date: 04.12.2024 - 11:00 am
*/
#endregion

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
            #region OOP's Essentials
            /*
            1. Inheritance
            2. Encapsulation
            3. Polymorphism
            4. Abstraction
            */
            #endregion

            // Change the background and text color
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            // Derive an object from car class
            Car car1 = new Car();
            car1.Brand = "Porche";
            car1.Model = "The 911 Carrera RS 2.7";
            car1.MadeYear = "1963";
            car1.ShowInformations();

            Console.WriteLine("\n");

            // Derive an object from student class
            Student student1 = new Student();
            student1.Name = "Barış";
            student1.Surname = "Someroğlu";
            student1.Exam1 = 60;
            student1.Exam2 = 50;
            student1.ShowInformation();

            // Get information from user
            Student student2 = new Student();
            Console.Write("\nName: ");
            student2.Name = Console.ReadLine();

            Console.Write("Surname: ");
            student2.Surname = Console.ReadLine();

            Console.Write("First Exam: ");
            student2.Exam1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Second Exam: ");
            student2.Exam2 = Convert.ToByte(Console.ReadLine());

            student2.ShowInformation();

            Console.ReadKey();

        }
    }
}
