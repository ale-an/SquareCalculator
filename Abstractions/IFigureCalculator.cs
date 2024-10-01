namespace Abstractions;

/// <summary>
/// Представляет интерфейс калькулятора фигуры.
/// </summary>
/// <typeparam name="T">
/// Интерфейс фигуры.
/// </typeparam>
public interface IFigureCalculator<T> where T : IFigure
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <param name="figure">
    /// Объект фигуры.
    /// </param>
    double CalculateSquare(T figure);
}