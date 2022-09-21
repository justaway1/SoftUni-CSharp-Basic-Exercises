using System;

namespace _19_Exercise
{
    internal class _19_Exercise
    {
        static void Main(string[] args)
        {
            //Екскурция
            double trip = double.Parse(Console.ReadLine());
            //Пъзел - 2.60 лв.
            int jigsaw = int.Parse(Console.ReadLine());
            //· Говореща кукла -3 лв.
            int talkingDoll = int.Parse(Console.ReadLine());
            //· Плюшено мече -4.10 лв.
            int bear = int.Parse(Console.ReadLine());
            //· Миньон - 8.20 лв.
            int minion = int.Parse(Console.ReadLine());
            //· Камионче - 2 лв.
            int truck = int.Parse(Console.ReadLine());

            double jigsawPrice = jigsaw * 2.60;
            double talkingDollPrice = talkingDoll * 3.00;
            double bearPrice = bear * 4.10;
            double minionPrice = minion * 8.20;
            double truckPrice = truck * 2.00;

            double totalToys = jigsaw + talkingDoll + bear + minion + truck;

            double totalPrice = jigsawPrice + talkingDollPrice + bearPrice + minionPrice + truckPrice;
            double rent = totalPrice - (totalPrice * 0.10);


            if (totalToys >= 50)
            {
                double discounted = totalPrice - (totalPrice * 0.25);
                rent = discounted - (discounted * 0.10);
            }
                if (rent >= trip)
                {
                    double profit = rent - trip;
                    Console.WriteLine($"Yes! {profit.ToString("0.00")} lv left.");
                }
                else
                {
                    double profit = trip - rent;
                    Console.WriteLine($"Not enough money! {profit.ToString("0.00")} lv needed.");
                }

        }
    }
}