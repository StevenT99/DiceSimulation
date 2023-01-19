using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is my greeting and where I get the number of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            // Then i put the number of rolls into a variable
            int numRolls = int.Parse(Console.ReadLine());

            // Here is my array
            int[] rollResults = new int[13]; 
            Random rand = new Random();

            // Here is where I roll the dice
            for (int i = 0; i < numRolls; i++)
            {
                int roll1 = rand.Next(1, 7);
                int roll2 = rand.Next(1, 7);
                int total = roll1 + roll2;
                rollResults[total]++;
            }
            // Here is where I display my results
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".");
            Console.WriteLine("");

            // Here is where I print the histogram. I am using a nested for loop. The outer loop goes from 2 to 12 and prints each total number as well as a colon.
            for (int i = 2; i <= 12; i++)
            {
                Console.Write(i + ": ");
                int percent = (int)((double)rollResults[i] / numRolls * 100);
                // This inner loop iterates for the times equal to the percentage of the total rolls for the current number 
                // I take the number of times it was rolled and divide it by the total number of rolls and multiply it by 100. Then i store it in the percent variable
                for (int j = 0; j < percent; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
