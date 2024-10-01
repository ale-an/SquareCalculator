using FluentAssertions;
using Models;

namespace Logic.Tests;

public class CircleCalculatorTests
{
    [Fact(DisplayName = $"{nameof(CircleCalculator)} может вычислять площадь круга")]
    public void CanCalculateSquare()
    {
        // Arrange
        var circleCalculator = new CircleCalculator();
        var circle = new Circle(4);
        
        // Act
        var result = circleCalculator.CalculateSquare(circle);
        
        // Assert
        result.Should().Be(50.26548245743669);
    }
}