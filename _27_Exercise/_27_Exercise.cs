using System;

namespace _27_Exercise
{
    internal class _27_Exercise
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();


            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal == "crocodile" ||
                     animal == "tortoise" ||
                     animal == "snake")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}