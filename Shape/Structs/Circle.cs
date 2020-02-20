using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Structs
{
    public struct Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius can not be less than zero", "radius");

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }
    }
}
