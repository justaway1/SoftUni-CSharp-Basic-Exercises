using System;

namespace _20_Exercise
{
    internal class _20_Exercise
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            double bonusMinutes = minutes + 15;


            if (hours >= 23 && minutes >= 55)
            {
                hours = 0;
                bonusMinutes %= 20;
                Console.WriteLine($"{hours}:{bonusMinutes}");
            }
            else if (hours >= 23 && minutes >= 45 && minutes <= 54)
            {
                hours = 0;
                bonusMinutes %= 10;
                Console.WriteLine($"{hours}:0{bonusMinutes}");
            }

            else if (minutes >= 45 && minutes <= 54)
            {
                bonusMinutes %= 10;
                hours++;
                Console.WriteLine($"{hours}:0{bonusMinutes}");
            }

            else if (minutes >= 55)
            {
                hours++;
                bonusMinutes %= 20;
                Console.WriteLine($"{hours}:{bonusMinutes}");
            }

            else
            {
                Console.WriteLine($"{hours}:{bonusMinutes}");
            }

        }
    }
}