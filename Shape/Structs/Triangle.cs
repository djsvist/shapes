using System;
using System.Linq;

namespace Shape.Structs
{
    public struct Triangle : IShape, IEquatable<Triangle>
    {
        public decimal A { get; }
        public decimal B { get; }
        public decimal C { get; }

        public Triangle(decimal a, decimal b, decimal c)
        {
            A = a;
            B = b;
            C = c;

            var max = new [] { a, b, c }.Max(); //Находим максимальную сторону
            if (a + b + c - max < max //Если сумма двух оставшихся сторон меньше третей стороны - такого треугольника не существует
                || c <= 0m || b <= 0m || c <= 0m) //Стороны треугольника не могут быть <= нуля
                throw new ArgumentException("This triangle cant be exists");
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight
        {
            get
            {
                decimal aa = (A * A), bb = B * B, cc = C * C;
                return (aa + bb == cc) || (aa + cc == bb) || (bb + cc == aa);
            }
        }

        public double Square
        {
            get
            {
                var halfPerimeter = (A + B + C) / 2;
                var v = halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C);
                return Math.Sqrt((double)v);
            }
        }

        public bool Equals(Triangle other)
        {
            return A.Equals(other.A) && B.Equals(other.B) && C.Equals(other.C);
        }

        public override bool Equals(object obj)
        {
            return obj is Triangle other && Equals(other);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = A.GetHashCode();
                hashCode = (hashCode * 397) ^ B.GetHashCode();
                hashCode = (hashCode * 397) ^ C.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator == (Triangle left, Triangle right) => left.Equals(right);

        public static bool operator !=(Triangle left, Triangle right) => !left.Equals(right);
    }
}
