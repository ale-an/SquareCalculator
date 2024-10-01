using FluentAssertions;

namespace Models.Tests;

public class CircleTests
{
    [Theory(DisplayName = $"{nameof(Circle)} не может быть с нулевым или отрицательным радиусом")]
    [InlineData(0)]
    [InlineData(-1)]
    public void CircleRadiusCannotBeZeroOrNegative(double radius)
    {
        // Act
        var exception = Record.Exception(() => new Circle(radius));
        
        // Assert
        exception.Should().NotBeNull().And.BeOfType<ArgumentException>();
    }
}