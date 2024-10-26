public class Simple : Goal 
{
    public Simple() : base() 
    {  
    }
    public Simple(string name, string description, double points, int timesFinished):base(name, description, points, timesFinished)
    {
    }

    public override bool IsComplete()
    {
        if(_timesCompleted >= 1)
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
        return RewardPoints(_points);
    }
    public override string SerializeSelf()
    {
        _formattedString = "Simple";
        return base.SerializeSelf();
    }
    public override void ListGoal() 
    {
        base.ListGoal();
        Console.Write($" --- Simple Goal\n");
    }

}