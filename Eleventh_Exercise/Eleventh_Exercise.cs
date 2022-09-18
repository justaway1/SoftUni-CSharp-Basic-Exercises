using System;


namespace Eleventh_Exercise
{
    internal class Eleventh_Exercise
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);

            }
            else if (secondNumber >= firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}