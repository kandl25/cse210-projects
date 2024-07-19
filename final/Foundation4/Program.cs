using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Jul 2024", 30, 3.0),
            new Cycling("04 Jul 2024", 45, 15.0),
            new Swimming("05 Jul 2024", 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
