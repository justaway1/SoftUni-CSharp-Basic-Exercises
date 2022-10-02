
using System;

namespace _45_Exercise
{
    internal class _45_Exercise
    {
        static void Main(string[] args)
        {

            //inputs
            double days = double.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0.0;
            double totalPrice = 0.0;


            //Act

            if (roomType == "room for one person")
            {
                price = 18;
                totalPrice = price * days;
            }
            else if (roomType == "apartment")
            {
                price = 25;
                totalPrice = price * days;

                if (days < 10)
                {
                    totalPrice -= (totalPrice * 0.30);
                }
                else if (days > 10 && days < 15)
                {
                    totalPrice -= (totalPrice * 0.35);
                }
                else if (days > 15)
                {
                    totalPrice -= (totalPrice * 0.50);
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35;
                totalPrice = price * days;

                if (days < 10)
                {
                    totalPrice -= (totalPrice * 0.10);
                }
                else if (days > 10 && days < 15)
                {
                    totalPrice -= (totalPrice * 0.15);
                }
                else if (days > 15)
                {
                    totalPrice -= (totalPrice * 0.20);
                }
            }

            if (rating == "positive")
            {
                totalPrice += (totalPrice * 0.25);
            }
            else
            {
                totalPrice -= (totalPrice * 0.10);
            }

            Console.WriteLine($"{totalPrice:0.00}");
        }
    }
}