using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        int menuResponse = 0;
        List<string> menu = new List<string>{
            "Please select one of the follow choises:",
            "1. Write",
            "2. Display",
            "3. Load ",
            "4. Save",
            "5. Quit",
            "What would you like to do?"
        };

        Console.WriteLine("Welcome to the Journal Program.");

        while (menuResponse!=5)
        {
            foreach (string line in menu)
            {
                Console.WriteLine(line);
            };
            menuResponse = Convert.ToInt32(Console.ReadLine());

            switch (menuResponse)
            {
                case 1: 
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM,dd,yyyy");

                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Name of file to load?");
                    string fileNameLoad = Console.ReadLine();
                    journal.LoadFromFile(fileNameLoad);
                    break;
                case 4:
                    Console.WriteLine("What is the filename?");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
            }
        } 
    
    }
}
