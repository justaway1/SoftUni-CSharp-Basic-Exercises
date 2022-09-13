using System;

namespace Fifth_Exercise
{
    internal class Fifth_Exercise
    {
        static void Main(string[] args)
        {

            double pens = double.Parse(Console.ReadLine()) * 5.80;
            double markers = double.Parse(Console.ReadLine()) * 7.20;
            double spray = double.Parse(Console.ReadLine()) * 1.20;
            int discount = int.Parse(Console.ReadLine());

            double finalPrice = pens + markers + spray;
            double finalDiscount = finalPrice - ((finalPrice * discount) / 100);

            Console.WriteLine(finalDiscount);

        }
    }
}