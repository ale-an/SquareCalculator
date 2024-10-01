using Abstractions;

namespace SquareCalculator;

/// <summary>
/// Калькулятор площади фигур.
/// </summary>
/// <typeparam name="T">
/// Тип фигуры.
/// </typeparam>
public class Calculator<T> where T : IFigure
{
    private readonly IFigureCalculator<T> figureCalculator;

    /// <summary>
    /// Создаёт экземпляр типа <see cref="Calculator{T}"/>
    /// </summary>
    /// <param name="figureCalculator">
    /// Калькулятор площади фигуры.
    /// </param>
    public Calculator(IFigureCalculator<T> figureCalculator)
    {
        this.figureCalculator = figureCalculator;
    }

    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <param name="figure">
    /// Фигура.
    /// </param>
    public double CalculateSquare(T figure) => figureCalculator.CalculateSquare(figure);
}