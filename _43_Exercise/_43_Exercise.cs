using System;

namespace _43_Exercise
{
    internal class _43_Exercise
    {
        static void Main(string[] args)
        {

            //Inputs
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            //Action


            if (season == "May" || season == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (days > 7 && days < 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (days > 14)
                {
                    studioPrice -= studioPrice * 0.30;
                    apartmentPrice -= apartmentPrice * 0.10;
                }
            }

            else if (season == "June" || season == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (days > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                }

            }

            else if (season == "July" || season == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;

                if (days > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                }

            }

            Console.WriteLine($"Apartment: {apartmentPrice * days:0.00} lv.");
            Console.WriteLine($"Studio: {studioPrice * days:0.00} lv.");
        }
    }
}