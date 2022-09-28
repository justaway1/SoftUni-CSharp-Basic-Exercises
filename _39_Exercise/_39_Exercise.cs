using System;

namespace _39_Exercise
{
    internal class _39_Exercise
    {
        static void Main(string[] args)
        {

            //Inputs
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());


            double price = 0.0;
            double totalPrice = 0.0;
            double remainingMoney = 0.0;

            if (flowers == "Roses")
            {
                price = 5.00;
                totalPrice = quantity * price;

                if (quantity > 80)
                {
                    totalPrice = totalPrice - (totalPrice * 0.10);
                }

                if (totalPrice > budget)
                {
                    remainingMoney = totalPrice - budget;
                    Console.WriteLine($"Not enough money, you need {remainingMoney:0.00} leva more.");
                }
                else
                {
                    remainingMoney = budget - totalPrice;
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {remainingMoney:0.00} leva left.");
                }
            }

            else if (flowers == "Dahlias")
            {
                price = 3.80;
                totalPrice = quantity * price;

                if (quantity > 90)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
                if (totalPrice > budget)
                {
                    remainingMoney = totalPrice - budget;
                    Console.WriteLine($"Not enough money, you need {remainingMoney:0.00} leva more.");
                }
                else
                {
                    remainingMoney = budget - totalPrice;
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {remainingMoney:0.00} leva left.");
                }

            }

            else if (flowers == "Tulips")
            {
                price = 2.80;
                totalPrice = quantity * price;
                if (quantity > 80)
                {
                    totalPrice -= (totalPrice * 0.15);
                }
                if (totalPrice > budget)
                {
                    remainingMoney = totalPrice - budget;
                    Console.WriteLine($"Not enough money, you need {remainingMoney:0.00} leva more.");
                }
                else
                {
                    remainingMoney = budget - totalPrice;
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {remainingMoney:0.00} leva left.");
                }

            }

            else if (flowers == "Narcissus")
            {
                price = 3.00;
                totalPrice = quantity * price;

                if (quantity < 120)
                {
                    totalPrice += (totalPrice * 0.15);
                }
                if (totalPrice > budget)
                {
                    remainingMoney = totalPrice - budget;
                    Console.WriteLine($"Not enough money, you need {remainingMoney:0.00} leva more.");
                }
                else
                {
                    remainingMoney = budget - totalPrice;
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {remainingMoney:0.00} leva left.");
                }
            }

            else if (flowers == "Gladiolus")
            {
                price = 2.50;
                totalPrice = quantity * price;
                if (quantity < 80)
                {
                    totalPrice += (totalPrice * 0.20);
                }
                if (totalPrice > budget)
                {
                    remainingMoney = totalPrice - budget;
                    Console.WriteLine($"Not enough money, you need {remainingMoney:0.00} leva more.");
                }
                else
                {
                    remainingMoney = budget - totalPrice;
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {remainingMoney:0.00} leva left.");
                }
            }


        }
    }
}