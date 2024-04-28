using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> ();        
        int number;
        
        do
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
       
            if (number != 0)
            {               
                numbers.Add(number);
            }
        } while (number !=0); 

        Console.WriteLine(" ");
        Console.WriteLine("Enter a list of numbers, type 0 to quit).");
        foreach (int num in numbers)
        {
            Console.WriteLine($"Enter number: {num}");
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

    }
}