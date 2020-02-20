using Shape.Structs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{

    /// <summary>
    /// Класс-обертка над примитивами
    /// Использовать не обязательно
    /// </summary>
    public static class Shapes
    {
        /// <summary>
        /// Создать стуктуру круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <returns></returns>
        public static Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Создать структуру треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Triangle CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }

        /// <summary>
        /// Рассчитать площадь круга
        /// </summary>
        /// <param name="radius">радиус</param>
        /// <returns></returns>
        public static double GetSquare(double radius)
        {
            return CreateCircle(radius).GetSquare();
        }

        /// <summary>
        /// Рассчитать площадь треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double GetSquare(double a, double b, double c)
        {
            return CreateTriangle(a, b, c).GetSquare();
        }
    }
}
