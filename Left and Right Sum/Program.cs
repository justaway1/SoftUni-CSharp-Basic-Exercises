using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int firstNumbersSum = 0;
            int secondNumbersSum = 0;
            int finalResult = 0;

            for (int i = 0; i < number; i++)
            {
                int firstNumbers = int.Parse(Console.ReadLine());

                firstNumbersSum += firstNumbers;

            }

            for (int i = 0; i < number; i++)
            {
                int secondNumbers = int.Parse(Console.ReadLine());

                secondNumbersSum += secondNumbers;
            }

            if (firstNumbersSum == secondNumbersSum)
            {
                finalResult += firstNumbersSum;
                Console.WriteLine($"Yes, sum = {finalResult}");
            }
            else if (firstNumbersSum != secondNumbersSum)
            {
                finalResult = Math.Abs(firstNumbersSum - secondNumbersSum);
                Console.WriteLine($"No, diff = {finalResult}");
            }



        }
    }
}