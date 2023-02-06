using Geometry.Shapes;
using Xunit;

namespace Tests;

public class TriangleTests
{
    [Fact]
    public void TriangleAreaCalculationTest()
    {
        // Построение
        var triangle = new Triangle(3, 4, 5);
        const int expected = 6;

        // Операции
        var actual = triangle.Area();

        // Проверка
        Assert.Equal(expected, actual, 2);
    }

    [Fact]
    public void TriangleIsValidTriangleTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(2, 2, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 8, 3));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 10, 5));
    }

    [Fact]
    public void TriangleIsRectangleTest()
    {
        // Построение
        var triangle = new Triangle(3, 4, 5);
        const bool expected = true;
        
        // Операции
        var actual = triangle.IsRectangle();
        
        // Проверка
        Assert.Equal(expected, actual);

    }
    
    [Fact]
    public void Triangle_Side_Validation_Test()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-4, 3, 10));
        Assert.Throws<ArgumentException>(() => new Triangle(0, 3, 10));
        Assert.Throws<ArgumentException>(() => new Triangle(4, -3, 10));
        Assert.Throws<ArgumentException>(() => new Triangle(4, 0, 10));
        Assert.Throws<ArgumentException>(() => new Triangle(4, 3, -10));
        Assert.Throws<ArgumentException>(() => new Triangle(4, 3, 0));
    }
}