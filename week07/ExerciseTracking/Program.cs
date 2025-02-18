using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create instances of each activity
        var running = new Running(new DateTime(2022, 11, 3), 30, 5.0);
        var cycling = new Cycling(new DateTime(2022, 11, 4), 45, 20.0);
        var swimming = new Swimming(new DateTime(2022, 11, 5), 30, 20);

        // Put the activities into a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Call GetSummary for each activity and display the results
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
