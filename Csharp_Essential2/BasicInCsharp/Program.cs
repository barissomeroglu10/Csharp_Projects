using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Explanation About Code
/*
 Purpose of the code is learn some essentials about C#

Developer: Barış Someroğlu
Date: 06.03.2025 - 01:10 am
*/
#endregion

namespace BasicInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Change the background and text color
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            #region Getting Value
            int x;

            Console.Write("Please Enter a Number: ");

            // We must convert value whic we get from user. Beacuse, in C# every things on the console are string
            // Therefor, we must convert string --> int
            x=Convert.ToInt32(Console.ReadLine());

            // Created an object from Methods class
            Methods object1 = new Methods();

            Console.WriteLine($"Factorial of {x}: {object1.Factorial(x)}");
            #endregion

            #region Array, foreach

            // Define array1
            byte[] array1 = {10, 20, 30, 40, 50};

            Console.WriteLine($"array1[0]: {array1[0]}");

            // Define array2
            byte[] array2 = new byte[array1.Length];
            // ... = new ...
            // We derive an object from System.Array class

            Console.WriteLine("\n");

            // Get value from user for array2
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"Please Enter a value for {i}. index: ");
                array2[i] = Convert.ToByte(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Console.Write("array2: ");

            // Write array2 to the console with using foreach loop
            foreach (byte item in array2)
            {
                Console.Write(item + " ");
            }

            #endregion

            #region Matrix

            // Define matrix
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,,] matrix2 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            Matrix matrix = new Matrix(matrix1, matrix2);

            matrix.PrintMatrix2();

            #endregion

            #region List
            // Define a list
            List<string> Names = new List<string>();

            // Add to list
            Names.Add("Baris");
            Names.Add("Yaser");
            Names.Add("Diyar");
            Names.Add("Coskun");

            // Write list to console with lambda
            Names.ForEach(i => Console.WriteLine(i));

            // Remove from list
            Names.Remove("Coskun");
            Names.RemoveAt(0);

            Console.WriteLine();
            Names.ForEach((i) => Console.WriteLine(i));

            // Add to list
            Names.Insert(0, "Hüseyin");

            Console.WriteLine();
            Names.ForEach((i) => Console.WriteLine(i));

            // Boolen output
            Console.WriteLine(Names.Contains("Coskun"));
            Console.WriteLine(Names.Contains("Hüseyin"));

            // Order the list
            Names.Sort();

            Console.WriteLine();
            Names.ForEach(i => Console.WriteLine(i));

            Names.Remove("Hüseyin");

            Console.WriteLine();
            Console.WriteLine(Names[0]);
            #endregion

            #region Using Methods

            // Call function
            object1.WriteScreen();
            object1.WriteScreen("Baris");

            // Call function
            int Collection = object1.Sum(10, 7);
            Console.WriteLine(Collection);

            // Many parameteres function (params key word)
            int Collection2 = object1.SumParams(1,2,3,4,5,6,7,8,9);
            Console.WriteLine(Collection2);

            int[] ints = { 1, 2, 3, 4 };
            int[] ints2 = object1.Square(ints);

            Console.WriteLine("\n");

            foreach (int item in ints2)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine($"\nSum: {object1.Sum(15,35)}");

            #endregion

            Console.ReadKey();

        }
    }
}
