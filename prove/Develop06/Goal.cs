public abstract class Goal 
{
    protected string _name;
    protected string _description;
    protected double _points;
    protected double _timesCompleted;
    protected string _formattedString;

    public Goal()
    {
        _name = SetName();
        _description = SetDescription();
        _points = setPoints();
        _timesCompleted = 0;
    }
    public Goal(string name, string description, double points, int timesFinished)
    {
        _name = name;
        _description = description;
        _points = points;
        _timesCompleted = timesFinished;
    }

    protected string SetName()
    {
        Console.Write("What is the name of your goal? ");
        return Console.ReadLine();
    }
    protected string SetDescription()
    {
        Console.Write("What is a short description of it? ");
        return Console.ReadLine();
    }
    protected int setPoints()
    {
        Console.Write("What is the amount of points assosciated with this goal? ");
        return int.Parse(Console.ReadLine());
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public double GetPoints()
    {
        return _points;
    }
    public double GetTimesFinished()
    {
        return _timesCompleted;
    }
    public virtual int GetReachBonus()
    {
        return 0;
    }
    public virtual int GetBonusPoints()
    {
        return 0;
    }

    public double RewardPoints(double points)
    {
        Console.WriteLine($"Congratualations! You have earned {_points} points!\n");
        return points;
    }

    public virtual double RecordEvent()
    {
        _timesCompleted += 1;
        return 0;
    }

    public abstract bool IsComplete();

    public virtual void ListGoal()
    {
        if(IsComplete())
        {
            Console.Write($" [X] {_name} ({_description})");
        }
        if(!IsComplete())
        {
            Console.Write($" [ ] {_name} ({_description})");
        }
    }

    public virtual string SerializeSelf()
    {
        _formattedString += $": {GetName()}"
                                +$": {GetDescription()}: {GetPoints()}"
                                +$": {GetTimesFinished()}";
        return _formattedString;
    }
}