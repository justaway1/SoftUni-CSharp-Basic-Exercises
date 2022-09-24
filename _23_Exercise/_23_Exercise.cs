using System;


namespace _23_Exercise
{
    internal class _23_Exercise
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());


            int videoCardsPrice = videoCards * 250;
            double processorsPrice = processors * (videoCardsPrice * 0.35);
            double ramPrice = ram * (videoCardsPrice * 0.10);

            double totalPrice = videoCardsPrice + processorsPrice + ramPrice;


            if (videoCards > processors)
            { 
                totalPrice -= (totalPrice * 0.15);
            }

            if (budget > totalPrice)
            {
                double remainingMoney = budget - totalPrice;
                Console.WriteLine($"You have {remainingMoney.ToString("0.00")} leva left!");
            }
            else if (totalPrice > budget)
            {
                double remainingMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {remainingMoney.ToString("0.00")} leva more!");
            }
            


        }
    }
}