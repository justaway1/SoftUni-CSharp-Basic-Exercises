
using System;

namespace Eight_Exercise
{
    internal class Eight_Exercise
    {
        static void Main(string[] args)
        {
            //1. Да се определят следните параметри 

            //Баскетболни кецове – цената им е 40 % по - малка от таксата за една година

            //Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете

            // Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип

            //Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

            int yearTax = int.Parse(Console.ReadLine());

            double shoes = yearTax - (yearTax * 0.4);
            double suit = shoes - (shoes * 0.2);
            double ball =  suit / 4;
            double accessories = ball / 5;

            //2. Какви ще са разходите от зададените параметри по-горе.

            double allTaxes = yearTax + shoes + suit + ball + accessories;

            Console.WriteLine(allTaxes);



        }

    }
}