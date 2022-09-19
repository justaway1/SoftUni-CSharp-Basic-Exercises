using System;

namespace _13_Exercise
{
    internal class _13_Exercise
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}