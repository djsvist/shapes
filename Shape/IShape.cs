using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    /// <summary>
    /// Интерфейс фигуры
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns></returns>
        double GetSquare();
    }
}
