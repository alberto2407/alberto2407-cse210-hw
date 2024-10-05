using System;

class Program
{
    static void Main(string[] args)
    {
        string UserInput = "";
        Reference reference = new Reference("Provers", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.");

        while (scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type quit to exit.");
            UserInput = Console.ReadLine();
            if (UserInput == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
    }
}