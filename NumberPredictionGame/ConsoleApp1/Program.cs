using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Developer: Barış Someroğlu
/*
Purpose of the code is make a number prediction game

Date: 14.03.2025 - 00:30 am
*/
#endregion

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            Random RandomNumberObject = new Random();
            int RandomNumber = RandomNumberObject.Next(1, 101);

            Console.WriteLine("\t\t\t\t\t WELCOME TO THE NUMBER PREDICTION GAME!");
            Console.WriteLine("\nRules of the game:");
            Console.WriteLine("1. Computer generates a random number between 1 and 100");
            Console.WriteLine("2. According to your input, you will see a feedback message");
            Console.WriteLine("\n\t\t\t Let's start and see after how many prediction you will find the correct number");

            NumberPrediction o1 = new NumberPrediction();
            o1.ControlMethod(RandomNumber);

            Console.ReadLine();
        }
    }
}