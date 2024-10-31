public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, int length, string type, float speed) : base(date, length, "Cycling")
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        float distance = (_speed * GetLength()) / 60;
        return distance;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        float pace = 60 / _speed;
        return pace;
    }
}