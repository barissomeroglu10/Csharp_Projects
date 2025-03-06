using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInCsharp
{
    public class Matrix
    {
        // Define matrix
        private int[,] matrix1;
        private int[,,] matrix2;

        // Constructor method
        public Matrix(int[,] matrix1, int[,,] matrix2)
        {
            this.matrix1 = matrix1;
            this.matrix2 = matrix2;
        }

        // Method to write matrix
        public void PrintMatrix2()
        {
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(2); k++)
                    {
                        Console.Write(matrix2[i, j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
