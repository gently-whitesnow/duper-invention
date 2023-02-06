namespace Geometry.Shapes;

public class Circle : Shape
{
    private readonly double _radius;
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius be greater than 0");

        _radius = radius;
    }
    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }
}