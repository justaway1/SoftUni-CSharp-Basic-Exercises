using System;

namespace _42_Exerise
{
    internal class _42_Exercise
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string myInput = Console.ReadLine();


            if (myInput == "+")
            {
                double finalResult = firstNumber + secondNumber;
                if (finalResult % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {finalResult} - even");

                }
                else
                {
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {finalResult} - odd");
                }
            }

            else if (myInput == "-")
            {
                double finalResult = firstNumber - secondNumber;
                if (finalResult % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {finalResult} - even");

                }
                else
                {
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {finalResult} - odd");
                }
            }

            else if (myInput == "/")
            {
                double finalResult = firstNumber / secondNumber;

                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {finalResult:0.00}");

                }

            }

            else if (myInput == "%")
            {
                double finalResult = firstNumber % secondNumber;
                if (secondNumber == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNumber} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} % {secondNumber} = {finalResult}");
                }


            }

            else if (myInput == "*")
            {
                double finalResult = firstNumber * secondNumber;
                if (finalResult % 2 == 0)
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {finalResult} - even");

                }
                else
                {
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {finalResult} - odd");
                }
            }
        }
    }
}