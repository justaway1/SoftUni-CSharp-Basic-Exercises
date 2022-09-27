
using System;
namespace _32_Exercise
{
    internal class _32_Exercise
    {
        static void Main(string[] args)
        {
            string weekDays = Console.ReadLine();

            int[] price = { 12, 12, 14, 14, 12, 16, 16 };

            if (weekDays == "Monday")
            {
                Console.WriteLine(price[0]);
            }
            else if (weekDays == "Tuesday")
            {
                Console.WriteLine(price[1]);
            }
            else if (weekDays == "Wednesday")
            {
                Console.WriteLine(price[2]);
            }
            else if (weekDays == "Thursday")
            {
                Console.WriteLine(price[3]);
            }
            else if (weekDays == "Friday")
            {
                Console.WriteLine(price[4]);
            }
            else if (weekDays == "Saturday")
            {
                Console.WriteLine(price[5]);
            }
            else if (weekDays == "Sunday")
            {
                Console.WriteLine(price[6]);
            }
        }
    }
}