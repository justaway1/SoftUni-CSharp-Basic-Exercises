using System;

namespace _36_Exercise
{
    internal class _36_Exercise
    {
        static void Main(string[] args)
        {
            //Град 0 ≤ s ≤ 500 500 < s ≤ 1 000 1 000 < s ≤ 10 000 s > 10 000
            //Sofia 5 % 7 % 8 % 12 
            //Varna 4.5 % 7.5 % 10 % 13 
            //Plovdiv 5.5 % 8 % 12 % 14.5 %

            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;


            if ((city != "Varna" && city != "Plovdiv" && city != "Sofia") ||
                (sales <= 0))
            {
                Console.WriteLine("error");
            }
            else if (city == "Sofia")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else
                {
                    commission = 0.12;
                }
                double finalResult = sales * commission;
                Console.WriteLine($"{finalResult:0.00}");
            }

            else if (city == "Varna")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.10;
                }
                else
                {
                    commission = 0.13;
                }
                double finalResult = sales * commission;
                Console.WriteLine($"{finalResult:0.00}");
            }

            else if (city == "Plovdiv")
            {
                if (sales > 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else
                {
                    commission = 0.145;
                }
                double finalResult = sales * commission;
                Console.WriteLine($"{finalResult:0.00}");
            }


        }
    }
}