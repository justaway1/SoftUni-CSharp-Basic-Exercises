using System;

namespace _21_Exercise
{
    internal class _21_Exercise
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double suits = double.Parse(Console.ReadLine());

            double priceDecor = budget * 0.10;
            double priceSuits = statists * suits;
            double totalSpent = priceDecor + priceSuits;



            if (statists >= 150)
            {
                double discountedPrice = priceSuits - (priceSuits * 0.10);
                totalSpent = discountedPrice + priceDecor;
            }

            if (totalSpent > budget)
            {
                double leftedMoney = totalSpent - budget;
                Console.WriteLine($"Not enough money! \nWingard needs {leftedMoney.ToString("0.00")} leva more.");
            }
            else
            {
                double leftedMoney = budget - totalSpent;
                Console.WriteLine($"Action! \nWingard starts filming with {leftedMoney.ToString("0.00")} leva left.");
            }
        }
    }
}