using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInCsharp
{
    public class Methods
    {
        #region Factorial Method

        public int Factorial(int x)
        {
            if (x <= 0)
            {
                return 1;
            }

            return x * Factorial(x-1);
        }

        #endregion

        #region Methods

        // No parameters - No Return Value
        public void WriteScreen()
        {
            Console.WriteLine("Hello, I learn C#");
        }

        // Parameter Field - Not Returning Value
        public void WriteScreen(string Name)
        {
            Console.WriteLine("$Hello {Name}");
        }

        // Parameter Field - Returning Value
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // params keyword -> use this keyword when the number of parameters not clear
        public int SumParams(params int[] values)
        {
            int Addition = 0;

            foreach (var i in values)
            {
                Addition += i;
            }

            return Addition;
        }

        // Takes an array as parameter - Returns array
        public int[] Square(int[] Array)
        {
            // make an object
            int[] arr = new int[Array.Length];

            for (int i = 0; i < Array.Length; i++)
            {
                arr[i] = Array[i] * Array[i];
            }

            return arr;
        }

        #endregion

        #region Lambda Functions
        static Func<int,int,int> Sum2 = (i, j) => i + j;

        static Func<int,int> Square2 = x => x * x;

        static Action<string> Warning = Name => Console.WriteLine("${Name} Warning");
        #endregion
    }
}
