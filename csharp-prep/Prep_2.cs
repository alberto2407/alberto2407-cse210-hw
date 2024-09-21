using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter = "";

        if (percentage >= 90)
        {
            if (percentage >= 97)
            {
                letter = "A+";
            }

            else if (percentage >= 93)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }
        }

        else if (percentage >= 80)
        {
            if (percentage >= 87)
            {
                letter = "B+";
            }

            else if (percentage >= 83)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }
        }

        else if (percentage >= 70)
        {
            if (percentage >= 77)
            {
                letter = "C+";
            }

            else if (percentage >= 73)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }
        }

        else if (percentage >= 60)
        {
            if (percentage >= 67)
            {
                letter = "D+";
            }

            else if (percentage >= 63)
            {
                letter = "D";
            }
            else
            {
                letter = "D-";
            }
        }

        else
        {
            if (percentage >= 57)
            {
                letter = "F+";
            }

            else if (percentage >= 53)
            {
                letter = "F";
            }
            else
            {
                letter = "F-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Good Job! You passed!");
        }

        else
        {
            Console.WriteLine("Sorry, maybe the next time");
        }
    }
}