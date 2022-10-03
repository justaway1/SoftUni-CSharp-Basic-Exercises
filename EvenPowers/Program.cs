using System;

namespace EvenPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= randomNumber; i+= 2)
            {
                
                    Console.WriteLine(Math.Pow(2, i));

            }
        }
    }
}