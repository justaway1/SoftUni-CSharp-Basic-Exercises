
using System;

namespace _24_Exercise
{
    internal class _24_Exercise
    {
        static void Main(string[] args)
        {
            string tvShow = Console.ReadLine();
            double tvShowLength = double.Parse(Console.ReadLine());
            double breakLength = double.Parse(Console.ReadLine());

            double freeTime = breakLength - (breakLength / 8) - (breakLength / 4);

            


            if (freeTime >= tvShowLength)
            {
                double remainingTime = freeTime - tvShowLength;
                Console.WriteLine($"You have enough time to watch {tvShow} and left with {Math.Ceiling(remainingTime)} minutes free time.");
            }
            else
            {
                double remainingTime = tvShowLength - freeTime;
                Console.WriteLine($"You don't have enough time to watch {tvShow}, you need {Math.Ceiling(remainingTime)} more minutes.");
            }
        }
    }		

}