namespace Geometry.Shapes;

public class Triangle : Shape
{
    public Triangle(double side1, double side2, double side3)
    {
        if (!IsValidTriangle(side1,side2,side3))
            throw new ArgumentException("Triangle with such sides does not exist");
        
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            throw new ArgumentException("Side length should be greater than 0");
        
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    private readonly double _side1;
    private readonly double _side2;
    private readonly double _side3;


    public override double Area()
    {
        double semiPerimeter = (_side1 + _side2 + _side3) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
    }

    public bool IsRectangle() =>
        Math.Abs(Math.Pow(_side1, 2) + Math.Pow(_side2, 2) - Math.Pow(_side3, 2)) < 0.001
        || Math.Abs(Math.Pow(_side1, 2) + Math.Pow(_side3, 2) - Math.Pow(_side2, 2)) < 0.001
        || Math.Abs(Math.Pow(_side2, 2) + Math.Pow(_side3, 2) - Math.Pow(_side1, 2)) < 0.001;

    private static bool IsValidTriangle(double side1, double side2, double side3) =>
        side1 + side2 > side3 &&
        side1 + side3 > side2 &&
        side2 + side3 > side1;
}