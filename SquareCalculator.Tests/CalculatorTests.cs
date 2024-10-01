using FluentAssertions;
using Logic;
using Models;

namespace SquareCalculator.Tests;

public class CalculatorTests
{
    [Fact(DisplayName = $"{nameof(Calculator<Triangle>)} может вычислять площадь треугольника")]
    public void CanCalculateTriangle()
    {
        // Arrange
        var triangleCalculator = new TriangleCalculator();
        var calculator = new Calculator<Triangle>(triangleCalculator);
        var triangle = new Triangle(3, 3, 3);

        // Act
        var result = calculator.CalculateSquare(triangle);

        // Assert
        result.Should().Be(3.897114317029974);
    }

    [Fact(DisplayName = $"{nameof(Calculator<Circle>)} может вычислять площадь круга")]
    public void CanCalculateSquare()
    {
        // Arrange
        var circleCalculator = new CircleCalculator();
        var calculator = new Calculator<Circle>(circleCalculator);
        var circle = new Circle(5);
        
        // Act
        var result = calculator.CalculateSquare(circle);
        
        // Assert
        result.Should().Be(78.53981633974483);
    }
}