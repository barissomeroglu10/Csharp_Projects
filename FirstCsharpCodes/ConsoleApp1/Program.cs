/*
Purpose of the code is learn C# essentials.

Developer: Barış Someroğlu
Date: 27.11.2024 - 11:20 am
*/

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
            // object includes all variables
            object obj = 5;

            byte b1 = 5;
            byte b2 = 10;

            // converting b1,b2 to string
            string s1 = b1.ToString();
            string s2 = b2.ToString();

            Console.WriteLine(b1 + " + " + b2 + " = " + (b1 + b2)); // byte proccess
            Console.WriteLine(s1 + " + " + s2 + " = " + (s1 + s2)); // string proccess

            Console.ReadKey();
        }
    }
}
