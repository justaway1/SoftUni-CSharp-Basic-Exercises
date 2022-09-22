using System;

namespace _22_Exercise
{
    internal class _22_Exercise
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double swimmingMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double supressionTime = Math.Round((swimmingMeters / 15)) * 12.5;
            double personalRecord = (swimmingMeters * timeInSeconds) + supressionTime;



            if (personalRecord >= worldRecord)
            {
                double result = personalRecord - worldRecord;
                Console.WriteLine($"No, he failed! He was {result.ToString("0.00")} seconds slower.");
            }
            else if (personalRecord < worldRecord)
            { }
                Console.WriteLine($"Yes, he succeeded! The new world record is {personalRecord.ToString("0.00")} seconds.");
            }
        }
    }
}