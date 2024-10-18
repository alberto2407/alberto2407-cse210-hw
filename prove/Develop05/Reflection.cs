using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Reflection : Activity
{
    protected List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something really difficult.", 
        "Think of a time when you did something truly selfless."
    };

    protected List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "Have you ever done anything like this before?", 
        "How did you feel when it was complete?", 
        "What is your favorite thing about this experience?",
        "What made this time different than other times when you were not as successful?", 
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    };

    public override void Execute()
    {
        ShowStartMessage("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random random = new Random();
        int time = duration;

        while (time > 0)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);
            Spinner(3);

            foreach (string question in questions)
            {
                if (time <= 0) break;

                Console.WriteLine(question);
                Spinner(5);
                time -= 5;
            }
        }

        ShowEndMessage("Reflection");
    }
}