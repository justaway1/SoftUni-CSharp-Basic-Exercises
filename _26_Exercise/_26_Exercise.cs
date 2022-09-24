using System;

namespace _26_Exercise
{
    internal class _26_Exercise
    {
        static void Main(string[] args)
        {

            string workingDays = Console.ReadLine();

            if (workingDays == "Monday" || workingDays == "Tuesday"
                 || workingDays == "Wednesday" || workingDays == "Thursday"
                 || workingDays == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (workingDays == "Saturday" || workingDays == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}