using System;

namespace _44_Exercise
{
    internal class _44_Exercise
    {
        static void Main(string[] args)
        {
            //  Първият ред съдържа час на изпита – цяло число от 0 до 23
            //· Вторият ред съдържа минута на изпита – цяло число от 0 до 59
            //· Третият ред съдържа час на пристигане – цяло число от 0 до 23
            //· Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59

            //Inputs
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());

            int remainingHour = 0;
            int remainingMinutes = (examMinutes + studentMinutes) % 60;



            if (examHour == studentHour && examMinutes == studentMinutes)
            {
                Console.WriteLine("On time");
            }
            







        }
    }
}