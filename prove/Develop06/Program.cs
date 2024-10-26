using System; 
using System.IO;

class Program
{
    public static void ListGoals(List<Goal> Goals)
    {
        Console.WriteLine("\nThe goals are:");
            for(int i = 0; i < Goals.Count; i++)
            {
                Console.Write($"{i + 1}.");
                Goals[i].ListGoal();
            }
    }
    static void WriteString(string value, bool newLine = false, int speed = 10)
    {
        foreach(char character in value)
        {
            Console.Write(character);
            Thread.Sleep(speed);
        }

        if(newLine == true)
        {
            Console.Write("\n");
        }
    }

    public static int Spinner(int time)
    {
        int timePassed = 0;
        for(int i = 0; i <= time; i += 1)
        {
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
        Console.Write("\b\nLet's continue!\b\n");
        return timePassed;
    }

    public static int LevelUp(int level, double points)
    {
        int newLevel = level;
        switch(level)
        {
            case 1:
            if(points >= 100)
            {
                newLevel = 2;
            }
                break;
            case 2:
            if(points >= 300)
            {
                newLevel = 3;
            }
                break;
            case 3:
            if(points >= 500)
            {
                newLevel = 4;
            }
                break;
            case 4:
            if(points >= 1000)
            {
                newLevel = 5;
            }
                break;
            case 5:
            if(points >= 1500)
            {
                newLevel = 6;
            }
                break;
            case 6:
            if(points >= 2250)
            {
                newLevel = 7;
            }
                break;
            case 7:
            if(points >= 3000)
            {
                newLevel = 8;
            }
                break;
            case 8:
            if(points >= 4000)
            {
                newLevel = 9;
            }
                break;
            case 9:
            if(points >= 5000)
            {
                newLevel = 10;
            }
                break;
        }

        if(level != newLevel)
        {
            WriteString($"Congratulations! You are Level {newLevel}!\n", true);
        }

        return newLevel;
    }

    static void Main(string[] args)
    {
        int input;
        List<Goal> Goals = new List<Goal>();
        double points = 0;
        int level = 1;
        string name = "";

        List<string> menu = new List<string>
        {
            "\nWelcome to the Eternal Quest Program!\n",
            "Menu options:",
            "\t1. Create New Goal",
            "\t2. List Goals",
            "\t3. Save Goals ",
            "\t4. Load Goals",
            "\t5. Record Event",
            "\t6. Quit",
            "Select a choice from the menu: "
        };

        while(true)
        {
            level = LevelUp(level, points);
            
            foreach(string line in menu)
            {
                Console.WriteLine(line);
            };
            
            input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    List<string> typeGoals = new List<string>
                    {
                        "The types of Goals are:",
                        "\t1. Simple Goal",
                        "\t2. Eternal Goal",
                        "\t3. Checklist Goal",
                        "Which type of goal would you like to create? "
                    };

                    foreach (string line in typeGoals)
                    {
                        Console.WriteLine(line);
                    };
                    
                    input = int.Parse(Console.ReadLine());
                    switch(input)
                    {
                        case 1:
                            Goals.Add(new Simple());
                            break;
                        case 2:
                            Goals.Add(new Eternal());
                            break;
                        case 3:
                            Goals.Add(new Checklist());
                            break;
                    }
                    break;
                case 2:
                    ListGoals(Goals);
                    Spinner(5);
                    break;
                case 3:
                    Console.Write("What would you like to name the file? ");
                    name = Console.ReadLine() + ".txt";
                    using (StreamWriter file = new StreamWriter(name))
                    {
                        file.WriteLine(points + ":" + level);
                        for(int i = 0; i < Goals.Count; i++)
                        {
                            file.WriteLine(Goals[i].SerializeSelf());
                        }
                    }
                    break;
                case 4:
                    if(name == "")
                    {
                        Console.WriteLine("Please enter the filename(leave out the extension. Ex.: .txt): ");
                        name = Console.ReadLine() + ".txt";
                    }
                    string[] lines = System.IO.File.ReadAllLines(name);
                    points = double.Parse(lines[0].Split(":")[0]);
                    level = int.Parse(lines[0].Split(":")[1]);
                    for(int i = 1; i < lines.Length; i++)
                    {
                        string[] values = lines[i].Split(":");
                        switch(values[0])
                        {
                            case "Simple":
                                Goals.Add(new Simple(values[1], values[2], double.Parse(values[3]), int.Parse(values[4])));
                                break;
                            case "Eternal":
                                Goals.Add(new Eternal(values[1], values[2], double.Parse(values[3]), int.Parse(values[4])));
                                break;
                            case "Checklist":
                                Goals.Add(new Checklist(values[1], values[2], double.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5]), int.Parse(values[6])));
                                break;
                        }
                    }
                    break;
                case 5:
                    ListGoals(Goals);
                    Console.Write("\nWhich goal did you accomplish? ");
                    input = int.Parse(Console.ReadLine());
                    points += Goals[input - 1].RecordEvent();
                    break;
                case 6:
                    return;
            }
            WriteString($"\nYou have {points} points.\n", true);
        }
    }
}