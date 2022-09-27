using System;
namespace _31_Exercise
{
    internal class _31_Exercise
    {
        static void Main(string[] args)
        {
            int workHours = int.Parse(Console.ReadLine());
            string workDay = Console.ReadLine();

            if (workDay == "Monday" || workDay == "Tuesday" || workDay == "Wednesday"
                || workDay == "Thursday" || workDay == "Friday" || workDay == "Saturday")
            {
                if (workHours >= 10 && workHours <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }

            }
            else if (workDay == "Sunday")
            { 
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}