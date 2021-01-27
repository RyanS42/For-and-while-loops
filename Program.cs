using System;

namespace Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "The Movies";
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WindowHeight = 30;

            Console.WriteLine("Welcome to MoviesPlus! Tickets Are $5. Please Insert Cash..");   
            
            int cash = Convert.ToInt32(Console.ReadLine());

            if(cash < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Thats not enough money.");
            }
            else if(cash == 5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acess Granted..");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int change = cash - 5;
                Console.WriteLine("Access Granted and " + change + " dollars in change.");
            }

            // wait before closing
            Console.ReadKey();

        }
    }
}
