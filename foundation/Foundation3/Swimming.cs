public class Swimming : Activity
{
    private int _laps;


    public Swimming(string date, int length, string type, int laps) : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        float distance = (_laps * 50 ) / 1000; 
        return distance;
    }

    public override float GetSpeed()
    {
        float speed = (60 * GetDistance()) / GetLength();
        string speedString = $"{speed:F2}";
        return float.Parse(speedString);
    }

    public override float GetPace()
    {
        float pace = GetLength() / GetDistance();
        return pace;
    }
}