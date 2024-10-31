public class Running : Activity
{
    private int _distance; 

    public Running(string date, int length, string type, int distance) : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {

        float speed = (60 * _distance) / GetLength();
        return speed;
    }

    public override float GetPace()
    {
        float pace = GetLength() / _distance;
        return pace;
    }

}