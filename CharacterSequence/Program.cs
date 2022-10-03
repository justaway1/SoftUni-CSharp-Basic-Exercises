using System;

namespace CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomWord = Console.ReadLine();

            for (int i = 0; i < randomWord.Length; i++)
            {
                Console.WriteLine(randomWord[i]);
            }
        }
    }
}