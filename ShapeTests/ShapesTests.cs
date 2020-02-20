using Shape;
using System;
using Xunit;

namespace ShapeTests
{
    public class ShapesTests
    {
        /// <summary>
        /// Тесты площади. результаты умножений и делений double нельзя сравнивать через ==
        /// </summary>
        [Fact]
        public void CircleSquareTest1()
        {
            double square = Shapes.GetSquare(1d);

            Assert.True(Math.Abs(square - 3.141d) < 0.001d);
        }

        [Fact]
        public void CircleSquareTest2()
        {
            double square = Shapes.GetSquare(5.7d);

            Assert.True(Math.Abs(square - 102.07d) < 0.001d);
        }

        [Fact]
        public void CircleSquareTest3()
        {
            double square = Shapes.GetSquare(4d);

            Assert.True(Math.Abs(square - 50.265d) < 0.001d);
        }

        /// <summary>
        /// Круга с отрицательным радиусом не может существовать
        /// </summary>
        [Fact]
        public void CircleExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => 
            {
                Shapes.CreateCircle(-1d);
            });
        }

        /// <summary>
        /// Тесты площади
        /// </summary>
        [Fact]
        public void TriangleSquareTest1()
        {
            double square = Shapes.GetSquare(4, 5, 3);

            Assert.Equal(6d, square);
        }

        [Fact]
        public void TriangleSquareTest2()
        {
            double square = Shapes.GetSquare(4, 10, 8);

            Assert.True(Math.Abs(square - 15.199d) < 0.001d);
        }

        /// <summary>
        /// Тест на некорректный размер треугольника
        /// </summary>
        [Fact]
        public void TriangleExceptionTest()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Shapes.CreateTriangle(4, 4, 10);
            });
        }

        [Fact]
        public void TriangleRightTest1()
        {
            Assert.True(Shapes.CreateTriangle(3, 4, 5).IsRight);
        }

        [Fact]
        public void TriangleRightTest2()
        {
            Assert.False(Shapes.CreateTriangle(3, 6, 5).IsRight);
        }
    }
}
