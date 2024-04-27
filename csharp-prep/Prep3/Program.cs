using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?: ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);

        Console.Write("What is the guess number?: ");
        string answer1 = Console.ReadLine();
        int guessNumber = int.Parse(answer1);

        
        if (magicNumber > guessNumber)
        {
            Console.Write("Higher");
        }
        else if (magicNumber < guessNumber)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("You guessed it!");
        }
    }
}