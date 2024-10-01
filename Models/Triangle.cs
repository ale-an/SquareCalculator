using Abstractions;

namespace Models;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : IFigure
{
    /// <summary>
    /// Создаёт экземпляр типа <see cref="Triangle"/>.
    /// </summary>
    /// <param name="sideA">
    /// Сторона А.
    /// </param>
    /// <param name="sideB">
    /// Сторона B.
    /// </param>
    /// <param name="sideC">
    /// Сторона C.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Возникает, когда стороны образуют невозможный треугольник.
    /// </exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsPossible(sideA, sideB, sideC))
            throw new ArgumentException("Невозможный треугольник");
            
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        IsRectangular = CheckIsRectangular(sideA, sideB, sideC);
    }
    
    /// <summary>
    /// Сторона А.
    /// </summary>
    public double SideA { get; private set; }
    
    /// <summary>
    /// Сторона B.
    /// </summary>
    public double SideB { get; private set; }
    
    /// <summary>
    /// Сторона C.
    /// </summary>
    public double SideC { get; private set; }
    
    /// <summary>
    /// Является ли прямугольным треугольник.
    /// </summary>
    public bool IsRectangular { get; private set; }

    private bool CheckIsRectangular(double sideA, double sideB, double sideC)
    {
        var sides = new[] { sideA, sideB, sideC }.OrderDescending().ToArray();

        return Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2);
    }

    private bool IsPossible(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC
               && sideB + sideC > sideA
               && sideA + sideC > sideB;
    }
}