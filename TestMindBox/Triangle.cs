namespace TestMindBox;

public class Triangle : Figure
{
    public double FirstSide { get; set; }
    public double SecondSide { get; set; }
    public double ThirdSide { get; set; }

    public Triangle(double firstSide, double secondSide, double thirdSide) : base("triangle")
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public bool IsRectangular()
    {
        return Math.Pow(FirstSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2) || Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2) || Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2);
    }

    public double GetSquare()
    {
        var p = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
    }
}