using System;

namespace _34_Exercise
{
    internal class _34_Exercise
    {
        static void Main(string[] args)
        {
            int rangeNumber = int.Parse(Console.ReadLine());

            if (rangeNumber == 0 && rangeNumber >= -0)
            {
                if (rangeNumber >= 100 && rangeNumber <= 200)
                {
                    Console.WriteLine();

                }
            }
            else if (rangeNumber < 100 || rangeNumber > 200)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}