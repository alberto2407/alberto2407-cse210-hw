using System;
using System.Collections.Generic;

class Listing : Activity
{
    protected List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void Execute()
    {
        ShowStartMessage("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Spinner(3);

        int time = duration;
        int items = 0;

        while (time > 0)
        {
            Console.Write("List as many responses as you can: ");
            string entry = Console.ReadLine();
            items++;
            time -= 5; 
        }

        Console.WriteLine($"You have listed {items} items.");
        ShowEndMessage("Listing");
    }
}