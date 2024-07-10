using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{

    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect by listing things that are important to you.";
        _prompts = new List<string>
        {
            "List your favorite hobbies.",
            "List the things you are grateful for.",
            "List the people you admire.",
            "List the places you want to visit."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        var userItems = GetListFromUser();
        Console.WriteLine("You listed:");
        foreach (var item in userItems)
        {
            Console.WriteLine($"- {item}");
        }
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Start listing items. Press Enter without typing anything to finish.");
        while (true)
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                break;
            items.Add(input);
        }
        return items;
    }
}
