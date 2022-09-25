using System;

namespace _28_Exercise
{
    internal class _28_Exercise
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            string title = Console.ReadLine();

            if (title == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (title == "f")

                if (age >= 16)

                {
                    Console.WriteLine("Ms.");
                }

                else
                {
                    Console.WriteLine("Miss");
                }

        }
    }
}