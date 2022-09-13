using System;

namespace Six_Exercise
{
    internal class Six_Exercise
    {
        static void Main(string[] args)
        {
            // **Предпазен найлон - 1.50 лв. за кв. метър

            //· Боя - 14.50 лв.за литър

            //· Разредител за боя - 5.00 лв.за литър

            //За всеки случай, към необходимите материали, Румен иска да добави още 10 % от количеството боя и 2 кв.м.найлон, разбира се и 0.40 лв.за торбички. Сумата, която се заплаща на майсторите за 1 час работа, е равна на 30 % от сбора на всички разходи за материали.

            //1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]
            double plastic = double.Parse(Console.ReadLine()) * 1.50;
            double paint = double.Parse(Console.ReadLine()) * 14.50;
            double paintWater = double.Parse(Console.ReadLine()) * 5.00;
            double workTime = double.Parse(Console.ReadLine());

            double additionalPlastic = 2 * 1.50;
            double additionalPaint = paint * 0.1;
            double plasticBag = 0.40;

            double materialSum = plastic + additionalPlastic + paint + additionalPaint + paintWater + plasticBag;
            double FinalWorkTime = workTime * (materialSum * 0.3);
            double finalSum = materialSum + FinalWorkTime;

            Console.WriteLine(finalSum);

            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]

            //3.Количество разредител(в литри) - цяло число в интервала[1…30]
            //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]

        }
    }
}