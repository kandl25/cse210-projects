using System;
using System.Diagnostics;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on your experiences by answering questions.";
        _prompts = new List<string>
        {
            "Think of a time when you were truly happy.",
            "Think of a challenging experience you overcame.",
            "Thinkof a moment that you are proud of."
        };
        _questions = new List<string>
        {
            "Why was this moment special?",
            "How did you feel during this moment?",
            "What did you learn from this experience?",
            "How can you apply this experience to your future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    private void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(2);
        }
    }
}