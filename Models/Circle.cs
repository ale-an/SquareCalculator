using Abstractions;

namespace Models;

/// <summary>
/// Круг.
/// </summary>
public class Circle : IFigure
{
    /// <summary>
    /// Создаёт экземпляр типа <see cref="Circle"/>.
    /// </summary>
    /// <param name="radius">
    /// Радиус круга.
    /// </param>
    /// <exception cref="ArgumentException">
    /// Возникает, когда радиус круга равен 0 или отрицательный.
    /// </exception>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус круга не может быть равен 0 или отрицательным");
        
        Radius = radius;
    }
    
    /// <summary>
    /// Радиус круга.
    /// </summary>
    public double Radius { get; private set; }
}