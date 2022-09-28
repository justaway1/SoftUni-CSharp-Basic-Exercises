using System;

namespace _37_Exercise
{
    internal class _37_Exercise
    {
        static void Main(string[] args)
        {
            //Premiere – премиерна прожекция, на цена 12.00 лева.

            //· Normal – стандартна прожекция, на цена 7.50 лева.

            //· Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            //Inputs

            string cinemaTicketType = Console.ReadLine();
            int seatRows = int.Parse(Console.ReadLine());
            int seatColumns = int.Parse(Console.ReadLine());

            double price = 0;

            //Acts

            if (cinemaTicketType == "Premiere")
            {
                price = (seatRows * seatColumns) * 12.00;
            }
            else if (cinemaTicketType == "Normal")
            {
                price = (seatRows * seatColumns) * 7.50;
            }
            else if (cinemaTicketType == "Discount")
            {
                price = (seatRows * seatColumns) * 5.00;
            }

            //Output

            Console.WriteLine($"{price:0.00} leva.");
        }
    }
}