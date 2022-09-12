using System;

namespace Second_Exercise
{
    internal class second_exercise
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double radius = radians * 180 / Math.PI;

            Console.WriteLine(radius);
        }
    }
}