using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write ("What is your grade percentage? ");
        string userPercentage = Console.ReadLine();
        int userGrade = int.Parse(userPercentage);

        string letter = " ";

        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade>= 80)
        {
            letter = "B";
        }
        else if (userGrade>= 70)
        {
            letter = "C";
        }
        else if (userGrade>= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine ($"Your letter grade is: {letter}");

        if (userGrade >= 70)
        {
            Console.WriteLine ("Congratulation, You passed this class!.");
        }
        else
        {
            Console.WriteLine ("Learn from this experience and come back stronger next time!.");
        }
    } 
}
