public class Fration
{
    private int _top;
    private int _bottom;

    public Fration()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fration(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fration(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}