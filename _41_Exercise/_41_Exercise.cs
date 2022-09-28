using System;

namespace _41_Exercise
{
    internal class _41_Exercise
    {
        static void Main(string[] args)
        {
            //Inputs

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //double remainingMoney = 0.0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget *= 0.30;
                    Console.WriteLine($"Somewhere in Bulgaria\nCamp - {budget:0.00}");
                }
                else if (season == "winter")
                {
                    budget *= 0.70;
                    Console.WriteLine($"Somewhere in Bulgaria \nHotel - {budget:0.00}");
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    budget *= 0.40;
                    Console.WriteLine($"Somewhere in Balkans\nCamp - {budget:0.00}");
                }
                else if (season == "winter")
                {
                    budget *= 0.80;
                    Console.WriteLine($"Somewhere in Balkans \nHotel - {budget:0.00}");
                }
            }

            else if (budget > 1000)
            {
                budget *= 0.90;
                Console.WriteLine($"Somewhere in Europe\nHotel - {budget:0.00}");
            }

            //Acts
        }
    }
}