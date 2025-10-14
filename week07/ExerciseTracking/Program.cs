using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Running run1 = new Running(new DateTime(2025, 10, 14), 30, 5.0); 
        Cycling cycle1 = new Cycling(new DateTime(2025, 10, 14), 60, 20.0); 
        Swimming swim1 = new Swimming(new DateTime(2025, 10, 14), 45, 40); 

        
        List<Activity> activities = new List<Activity>();
        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);

        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
