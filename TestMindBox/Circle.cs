namespace TestMindBox;

public class Circle : Figure
{
    public float Radius { get; set; }


    public Circle(float radius) : base("circle")
    {
        Radius = radius;
    }

    public double GetSquare()
    {
        return 3 * Radius * Radius;
    }
}