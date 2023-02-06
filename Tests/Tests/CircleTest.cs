using Geometry.Shapes;
using Xunit;

namespace Tests;

public class CircleTest
{
    [Fact]
    public void CircleAreaCalculationTest()
    {
        // Построение
        var circle = new Circle(5);
        const double expected = Math.PI * 5 * 5;

        // Операции
        var actual = circle.Area();

        // Проверка
        Assert.Equal(expected, actual, 2);
    }
    
    [Fact]
    public void CircleRadiusValidationTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
}