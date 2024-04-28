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

        Console.WriteLine("Enter a number (0 to quit)");
        foreach (int num in numbers)
        {
            Console.WriteLine($"Enter number: {num}");
        }

    }
}