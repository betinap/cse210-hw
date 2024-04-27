using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?: ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);

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