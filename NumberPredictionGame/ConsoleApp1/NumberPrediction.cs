using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NumberPrediction
{
    public void ControlMethod(int RandomNumber)
    {
        int PredictionCounter = 0;
        int UserPrediction = -1;

        while (UserPrediction != RandomNumber)
        {
            // Get value from user
            Console.Write("Please Enter Your Prediction: ");
            UserPrediction = Convert.ToInt32(Console.ReadLine());
            PredictionCounter++;

            if (UserPrediction < RandomNumber)
            {
                Console.WriteLine("Input a bigger number!");
            }
            else if (UserPrediction > RandomNumber)
            {
                Console.WriteLine("Input a less number!");
            }
        }

        Console.WriteLine("Congrats you found the number!");
        Console.WriteLine($"You found the number at {PredictionCounter}. try");

        Console.WriteLine("End of the game!");

        for (int i = 1; i <= 100; i++)
        {
            Console.Write($"Game is closing %{i} \r"); // \r return the first line
            System.Threading.Thread.Sleep(30); // wait 30 ms
        }

        Console.WriteLine("\nGame closed!");
    }
}