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
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.Write("Hold...");
            ShowCountDown(5);
            Console.Write("Breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}
