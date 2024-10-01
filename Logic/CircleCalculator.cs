using Abstractions;
using Models;

namespace Logic;

/// <summary>
/// Калькулятор площади круга.
/// </summary>
public class CircleCalculator : IFigureCalculator<Circle>
{
    /// <inheritdoc />
    public double CalculateSquare(Circle figure)
    {
        return Math.PI * figure.Radius * figure.Radius;
    }
}