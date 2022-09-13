
using System;

namespace Fourth_Exercise

{
    internal class Fourth_Exercise
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int readPages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            //Да се отпечата на конзолата броят часове, които Жоро трябва да отделя за четене всеки ден.
            // 200 страници    // 30 за час = 
            int hoursNeeded = (bookPages / readPages) / days;

            Console.WriteLine(hoursNeeded);
        }
    }
}