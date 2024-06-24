using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    theJournal.AddEntry(promptGenerator);
                    break;
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file name to load from: ");
                    string loadFileName = Console.ReadLine();
                    theJournal.LoadFromFile(loadFileName);
                    break;
                case "4":
                    Console.Write("Enter the file nameto save to (end file name with '.txt'): ");
                    string saveFileName = Console.ReadLine();
                    theJournal.SaveToFile(saveFileName);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }
    static string GetDateTime()
    // Method to get the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        // Console.WriteLine(now.ToString("F"));
        // Displays Saturday, March 01, 2008 7:00:00 AM
        return currentDateTime;
    }
    static void AddJournalEntry()
    // Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }
}