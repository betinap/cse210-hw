using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is the guess number?: ");
            string answer1 = Console.ReadLine();
            guessNumber = int.Parse(answer1);

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}