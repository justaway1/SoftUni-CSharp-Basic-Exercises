
using System;

namespace _16_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side);
            }
            else if (figure == "rectangle")
            {
                var side = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                Console.WriteLine(side * side2);
            }
            else if (figure == "circle")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine((side * side) * Math.PI);
            }
            else if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var side1 = double.Parse(Console.ReadLine());
                Console.WriteLine((side * side1) / 2);
            }
        }
    }
}