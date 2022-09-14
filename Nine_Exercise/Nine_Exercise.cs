
using System;

namespace Nine_Exercise
{
    internal class Nine_Exercise
    {
        static void Main(string[] args)


        {

            //1. Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.

            //1.Дължина в см – цяло число в интервала[10 … 500]

            //2.Широчина в см – цяло число в интервала[10 … 300]

            //3.Височина в см – цяло число в интервала[10… 200]

            //4.Процент – реално число в интервала[0.000 … 100.000]


            int longNeeded = int.Parse(Console.ReadLine());
            int widthNeeded = int.Parse(Console.ReadLine());
            int heightNeeded = int.Parse(Console.ReadLine());
            double percentNeeded = double.Parse(Console.ReadLine());

            //Да се отпечата на конзолата едно число:

            double volume = longNeeded * widthNeeded * heightNeeded;
            double volumeLitre = volume / 1000;
            double spaceNeeded = percentNeeded / 100;
            double litreNeeded = volumeLitre * (1 - spaceNeeded);

            //· литрите вода, които ще събира аквариума.


            Console.WriteLine(litreNeeded);


        }
    }
}