#region CodeDescription
/*
Purpose of the code is calculate BMI with C#
 
Developer: Barış Someroğlu
Date: 27.11.2024 - 12:00 am
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyMassIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            string Name, Surname;
            float Weight = 0F, Height = 0F, BMI = 0F;
            #endregion

            #region Inputs
            Console.WriteLine("Please Enter Your Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Surname: ");
            Surname = Console.ReadLine();

            Console.WriteLine("Please Enter Your Kilo");
            Weight = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter Your Height in cm: ");
            Height = Convert.ToSingle(Console.ReadLine()) / 100;
            #endregion

            #region BMI and Conditions
            /*
            BMI = Kilo/(Height * Height)
            Underweight: Less than 18.5.
            Healthy Weight: 18.5 to less than 25.
            Overweight: 25 to less than 30.
            Obesity: 30 or greater.
            */
            

            BMI = Weight / (Height * Height);
            #endregion

            #region Results
            if (BMI < 18.5)
            {
                Console.WriteLine("Your Result is Underweight");
            }

            else if(BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Your Result is Healthy Weight");
            }

            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Your Result is Overweight");
            }

            else
            {
                Console.WriteLine("Your Result is Obesity");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
