using FluentAssertions;
using Models;

namespace Logic.Tests;

public class TriangleCalculatorTests
{
    [Fact(DisplayName = $"{nameof(TriangleCalculator)} может вычислять площадь треугольника")]
    public void CanCalculateSquare()
    {
        // Arrange
        var triangleCalculator = new TriangleCalculator();
        var triangle = new Triangle(3, 3, 3);
        
        // Act
        var result = triangleCalculator.CalculateSquare(triangle);
        
        // Assert
        result.Should().Be(3.897114317029974);
    }
}