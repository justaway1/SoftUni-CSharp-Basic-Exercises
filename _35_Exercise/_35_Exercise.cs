using System;

namespace _35_Exercise
{
    internal class _35_Exercise
    {
        static void Main(string[] args)
        {
            string fruits = Console.ReadLine();
            string weekDays = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;


            if
                ((fruits != "banana" && fruits != "apple" && fruits != "orange" && fruits != "grapefruit"
                && fruits != "kiwi" && fruits != "pineapple" && fruits != "grapes")
                ||
                (weekDays != "Monday" && weekDays != "Tuesday" && weekDays != "Wednesday" &&
                weekDays != "Thursday" && weekDays != "Friday" && weekDays != "Saturday" && weekDays != "Sunday"))
            {
                Console.WriteLine("error");

            }

            else if (weekDays == "Monday" || weekDays == "Tuesday" || weekDays == "Wednesday" ||
                weekDays == "Thursday" || weekDays == "Friday")
            {
                if (fruits == "banana")
                {
                    price = 2.50;
                }
                else if (fruits == "apple")
                {
                    price = 1.20;
                }
                else if (fruits == "orange")
                {
                    price = 0.85;
                }
                else if (fruits == "grapefruit")
                {
                    price = 1.45;
                }
                else if (fruits == "kiwi")
                {
                    price = 2.70;
                }
                else if (fruits == "pineapple")
                {
                    price = 5.50;
                }
                else if (fruits == "grapes")
                {
                    price = 3.85;
                }
                double totalPrice = quantity * price;
                Console.WriteLine($"{totalPrice:0.00}");
            }

            else if (weekDays == "Saturday" || weekDays == "Sunday")
            {
                if (fruits == "banana")
                {
                    price = 2.70;
                }
                else if (fruits == "apple")
                {
                    price = 1.25;
                }
                else if (fruits == "orange")
                {
                    price = 0.90;
                }
                else if (fruits == "grapefruit")
                {
                    price = 1.60;
                }
                else if (fruits == "kiwi")
                {
                    price = 3.00;
                }
                else if (fruits == "pineapple")
                {
                    price = 5.60;
                }
                else if (fruits == "grapes")
                {
                    price = 4.20;
                }
                double totalPrice = quantity * price;
                Console.WriteLine($"{totalPrice:0.00}");
            }


        }
    }
}