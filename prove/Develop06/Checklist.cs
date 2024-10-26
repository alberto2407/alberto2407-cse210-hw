public class Checklist : Goal 
{
    private int _reachBonus;
    private int _bonus;
    
    public Checklist() : base() 
    {

        _reachBonus = SetReachBonus();
        _bonus = SetBonusPoints();
    }

    public Checklist(string name, string description, double points, int timesFinished, int reach, int bonus):base(name, description, points, timesFinished) 
    {

        _reachBonus = reach;
        _bonus = bonus;
    }

    protected int SetReachBonus()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        return int.Parse(Console.ReadLine());
    }

    protected int SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        return int.Parse(Console.ReadLine());
    }

    public override int GetReachBonus()
    {
        return _reachBonus;
    }

    public override int GetBonusPoints()
    {
        return _bonus;
    }

    public override void ListGoal() 
    {
        base.ListGoal();
        Console.Write($" --- Currently completed: {_timesCompleted}/{_reachBonus}\n");
    }

    public override bool IsComplete()
    {
        if(_timesCompleted >= _reachBonus)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public override double RecordEvent()
    {
        base.RecordEvent();
        if(IsComplete())
        {
            return RewardPoints(_bonus + _points);
        }
        else 
        {
            return RewardPoints(_points);
        }
    }

    public override string SerializeSelf()
    {
        _formattedString = "Checklist";
        base.SerializeSelf();
        _formattedString += $"/{GetReachBonus()}: {GetBonusPoints()}";
        return _formattedString;
    }
}