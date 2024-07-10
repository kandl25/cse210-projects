using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through deep breathing exercises.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Hold...");
            ShowCountDown(7);
            Console.WriteLine("Breathe out...");
            ShowCountDown(8);
        }
        DisplayEndingMessage();
    }
}
