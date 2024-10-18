using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        List<string> menu = new List<string>{
            "Please, select one of the following activities:",
            "1. Breathing",
            "2. Reflection",
            "3. Listing ",
            "4. Quit\n",
            "Which activity would you like to do?"
        };

        Console.WriteLine("\nWelcome to the Mindfulness Program.\n");

        while (response != 5)
        {
            foreach (string line in menu)
            {
                Console.WriteLine(line);
            };
            response = Convert.ToInt32(Console.ReadLine());

            switch (response)
            {
                case 1:
                    Breathing breathing = new Breathing();
                    breathing.Execute();    
                break;
                case 2:
                    Reflection reflection = new Reflection();
                    reflection.Execute();
                break;
                case 3:
                    Listing listing = new Listing();
                    listing.Execute();                    
                break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }       
        }
    }
}