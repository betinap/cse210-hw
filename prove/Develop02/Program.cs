using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    //static List<Entry> entries = new List<Entry>();
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator(); 
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1-Write");
            Console.WriteLine("2-Display");
            Console.WriteLine("3-Save");
            Console.WriteLine("4-Load");
            Console.WriteLine("5-Quit");
            Console.Write("What would you like to do?: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write($"Write your answer: ");

                string entryText = Console.ReadLine();
                Entry entry = new Entry(DateTime.Now.ToString(), prompt, entryText);
                journal.AddEntry(entry);                

            }
            else if (input == "2")
            {
                journal.DisplayAll();
            }
            
            else if (input =="3")
            {
                Console.Write("Enter the file name to save to: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);                
            }

            else if (input=="4")
            {
                Console.Write("Enter the file name to load from: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);        
            }
            else
            {
                quit = true;
            }
        }
    }
}