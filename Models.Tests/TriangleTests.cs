using FluentAssertions;

namespace Models.Tests;

public class TriangleTests
{
    [Fact(DisplayName = $"{nameof(Triangle)} не может быть невозможным")]
    public void TriangleCannotBeImpossible()
    {
        // Arrange
        var sideA = 5;
        var sideB = 1;
        var sideC = 1;
        
        // Act
        var exception = Record.Exception(() => new Triangle(sideA, sideB, sideC));
        
        // Assert
        exception.Should().NotBeNull().And.BeOfType<ArgumentException>();
    }

    [Fact(DisplayName = $"{nameof(Triangle)} может быть прямоугольным")]
    public void Test()
    {
        // Arrange
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;
        
        // Act
        var triangle = new Triangle(sideA, sideB, sideC);
        
        // Assert
        triangle.IsRectangular.Should().Be(true);
    }
}