using Abstractions;
using Models;

namespace Logic;

/// <summary>
/// Калькулятор площади треугольника.
/// </summary>
public class TriangleCalculator : IFigureCalculator<Triangle>
{
    /// <inheritdoc />
    public double CalculateSquare(Triangle figure)
    {
        var halfPer = (figure.SideA + figure.SideB + figure.SideC) / 2;
        var root = halfPer * (halfPer - figure.SideA) * (halfPer - figure.SideB) * (halfPer - figure.SideC);
        return Math.Sqrt(root);
    }
}