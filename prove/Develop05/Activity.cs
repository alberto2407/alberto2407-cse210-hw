using System;
using System.Threading;

public abstract class Activity
{
    protected int duration; 
    public void ShowStartMessage(string activityName, string description)
    {
        Console.WriteLine($"Activity: {activityName}");
        Console.WriteLine(description);
        Console.Write("How long, in seconds, would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Spinner(3); 
    }

    public void ShowEndMessage(string activityName)
    {
        Console.WriteLine("Good Job!");
        Spinner(3);
        Console.WriteLine($"You have completed your {duration} seconds of the {activityName} Activity!");
        Spinner(3);
    }

    public int Spinner(int time)
    {
        int timePassed = 0;
        for(int i = 0; i <= time; i+=1){
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            timePassed += 1;
        }
        Console.Write("\b.\b\n");
        return timePassed;
    }
    public abstract void Execute();
}