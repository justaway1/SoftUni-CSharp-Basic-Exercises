using System;

namespace _30_Exercise
{
    internal class _30_Exercise
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number == 0)
            {
                if (number > -0.01 && number < 1 )
                {
                    Console.WriteLine("No");

                }
            }

            else if (number >= -100 && number <= 100)
            {
                Console.WriteLine("Yes");
            }

        }
    }
}