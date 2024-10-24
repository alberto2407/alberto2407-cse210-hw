public class Circle : Shape
{
    private double _radius;
    
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        double result = Math.PI * _radius * _radius;
        string resultString = $"{result:F2}";
        return double.Parse(resultString);
    }
}