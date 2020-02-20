using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shape.Structs
{
    public struct Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            double max = new double[] { a, b, c }.Max(); //Находим максимальную сторону
            if (a + b + c - max < max //Если сумма двух оставшихся сторон меньше третей стороны - такого треугольника не существует
                || c <= 0d || b <= 0d || c <= 0d) //Стороны треугольника не могут быть <= нуля
                throw new ArgumentException("This triangle cant be exists");
        }
        public double GetSquare()
        {
            var p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight
        {
            get
            {
                double AA = A * A, BB = B * B, CC = C * C;
                return (AA + BB == CC) || (AA + CC == BB) || (BB + CC == AA);
            }
        }
    }
}
