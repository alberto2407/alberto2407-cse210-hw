using System.Runtime.CompilerServices;

public abstract class Activity
{
   private string _date;
   private int _length; 
   private string _type;

    public Activity(string date, int length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }

    public string GetSummary()
    {

        string summary = _date + " " + _type + " (" + _length + " min): Distance " + GetDistance() + " km, Speed: " + GetSpeed() + " kph, Pace: " + GetPace() + " min per km";

        return summary;
    }
}