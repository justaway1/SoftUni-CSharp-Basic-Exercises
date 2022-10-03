using System;

namespace NumbersN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = int.Parse(Console.ReadLine());

            for (int i = randomNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
    }

    
}