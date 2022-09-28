
using System;

namespace _40_Exercise
{
    internal class _40_Exercise
    {
        static void Main(string[] args)
        {
            //inputs
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numPeople = int.Parse(Console.ReadLine());

            double price = 0;
            double remainingMoney = 0;

            //Act
            if (season == "Spring")
            {
                price = 3000;

                if (numPeople >= 1 && numPeople <= 6)
                {
                    price -= (price * 0.10);
                }
                else if (numPeople >= 7 && numPeople <= 11)
                {
                    price -= (price * 0.15);
                }
                else if (numPeople >= 12)
                {
                    price -= (price * 0.25);
                }
                if (numPeople % 2 == 0 && season != "Autumn")
                {
                    price -= (price * 0.05);
                }
                if (budget >= price)
                {
                    remainingMoney = budget - price;
                    Console.WriteLine($"Yes! You have {remainingMoney:0.00} leva left.");
                }
                else
                {
                    remainingMoney = price - budget;
                    Console.WriteLine($"Not enough money! You need {remainingMoney:0.00} leva.");
                }
            }

            if (season == "Summer" || season == "Autumn")
            {
                price = 4200;

                if (numPeople >= 1 && numPeople <= 6)
                {
                    price -= (price * 0.10);
                }
                else if (numPeople >= 7 && numPeople <= 11)
                {
                    price -= (price * 0.15);
                }
                else if (numPeople >= 12)
                {
                    price -= (price * 0.25);
                }
                if (numPeople % 2 == 0 && season != "Autumn")
                {
                    price -= (price * 0.05);
                }
                if (budget >= price)
                {
                    remainingMoney = budget - price;
                    Console.WriteLine($"Yes! You have {remainingMoney:0.00} leva left.");
                }
                else
                {
                    remainingMoney = price - budget;
                    Console.WriteLine($"Not enough money! You need {remainingMoney:0.00} leva.");
                }
            }

            if (season == "Winter")
            {
                price = 2600;

                if (numPeople >= 1 && numPeople <= 6)
                {
                    price -= (price * 0.10);
                }
                else if (numPeople >= 7 && numPeople <= 11)
                {
                    price -= (price * 0.15);
                }
                else if (numPeople >= 12)
                {
                    price -= (price * 0.25);
                }
                if (numPeople % 2 == 0 && season != "Autumn")
                {
                    price -= (price * 0.05);
                }
                if (budget >= price)
                {
                    remainingMoney = budget - price;
                    Console.WriteLine($"Yes! You have {remainingMoney:0.00} leva left.");
                }
                else
                {
                    remainingMoney = price - budget;
                    Console.WriteLine($"Not enough money! You need {remainingMoney:0.00} leva.");
                }
            }


            //output
        }
    }
}