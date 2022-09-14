
using System;

namespace Seventh_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Записваме конзолните стойности

            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            //Пилешко меню – 10.35 лв
            //• Меню с риба – 12.40 лв
            //• Вегетарианско меню – 8.15 лв.

            double chickenPrice = chickenMenu * 10.35;
            double fishPrice = fishMenu * 12.40;
            double vegetarianPrince = vegetarianMenu * 8.15;
            double delivery = 2.50;
            //2. Да сметнем колко ще излезе поръчката храна за вкъщи от менюто.

            double fullPrice = chickenPrice + fishPrice + vegetarianPrince;

            //2.5 Десерта е 20% от общата сметка.
            double desertPrice = fullPrice * 0.2;

            //2.6 Да се сметне доставката, която е накрая и е 2.50.

            double AllPriceSum = fullPrice + desertPrice + delivery;

            //3. Крайният конзолен резултат.

            Console.WriteLine(AllPriceSum);
        }
    }
}