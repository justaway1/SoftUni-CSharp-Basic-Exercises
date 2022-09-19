using System;

namespace _14_Exercise
{
    internal class _14_Exercise
    {
        static void Main(string[] args)
        {
            int guessNumber = int.Parse(Console.ReadLine());


            if (guessNumber < 100)
            {
                Console.WriteLine("Less than 100");
            }
             else if (guessNumber >= 100 && guessNumber <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}