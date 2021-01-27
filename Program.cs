using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many iterations of 2^i numbers do you want: ");

            // how many times you want the math to compute (2^i)
            int count = Convert.ToInt32(Console.ReadLine());

            // For loop (2^i)
            for (int i = 1; i <= count; i++)
            {
                // (2^i) 
                double res = Math.Pow(2, i);
                Console.WriteLine(res);
            }

            Console.WriteLine("\n\n..Now we move onto roll a dice: \n\n");

            // Random number generator 
            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press Enter to roll the die until you get a 6.");

            // Creates while loop for random numbers until we get 6
            // Once rolls a 6, drops out of while loop
            while(roll != 6) 
            {
                Console.ReadKey();     // waits for user to press a key
                roll = numberGen.Next(1, 7);  // the 7th is exclusive so if 6 numbers on a die have to go to 7 to get the 6th value
                Console.WriteLine("\nYou rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("\nIt took you " + attempts + " iterations to roll a six.\n");


           // Wait before closing
            Console.ReadKey(); 
        }
    }
}