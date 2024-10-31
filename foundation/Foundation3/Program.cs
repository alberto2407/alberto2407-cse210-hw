using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("09 Dec 2023", 33, "Running", 5));
        activities.Add(new Swimming("07 Nov 2023", 45, "Swimming", 20));
        activities.Add(new Cycling("08 Jul 2023", 60, "Cycling", 30));

        Console.WriteLine("List of activities: ");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());   
        }
    }
}