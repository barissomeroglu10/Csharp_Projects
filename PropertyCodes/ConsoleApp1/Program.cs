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
            // define variables
            double ExamScore1 = 0.0f;
            double ExamScore2 = 0.0f;

            // get value from user for variables
            Console.Write("Please Enter 1. Exam Score: ");
            ExamScore1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease Enter 2. Exam Score: ");
            ExamScore2 = Convert.ToDouble(Console.ReadLine());

            ControlAndCalculate o1 = new ControlAndCalculate();

            o1._ExamScore1 = ExamScore1;
            o1._ExamScore2 = ExamScore2;

            o1.AvverageExam();
        }
    }
}
