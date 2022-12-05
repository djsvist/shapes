using System;
using System.Data.Common;

namespace Shape.Structs
{
    public struct Circle : IShape, IEquatable<Circle>
    {
        public decimal Radius { get; }

        public Circle(decimal radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius can not be less than zero", nameof(radius));

            Radius = radius;
        }

        public double Square => Math.PI * Math.Pow((double)Radius, 2d);

        public bool Equals(Circle other)
        {
            return Radius.Equals(other.Radius);
        }

        public override bool Equals(object obj)
        {
            return obj is Circle other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }

        public static bool operator == (Circle left, Circle right) => left.Equals(right);

        public static bool operator != (Circle left, Circle right) => !left.Equals(right);
    }
}
