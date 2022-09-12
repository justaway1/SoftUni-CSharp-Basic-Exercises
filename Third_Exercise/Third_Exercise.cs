using System;

namespace Third_Exercise


{
    internal class Third_Exercise
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double yearTax = double.Parse(Console.ReadLine());

            double calculateSum = deposit + months * ((deposit * yearTax / 100) / 12);

            Console.WriteLine(calculateSum);

        }
    }
}