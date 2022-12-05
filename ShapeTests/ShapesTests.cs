using Shape.Structs;
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
            var square = new Circle(1).Square;

            Assert.True(Math.Abs(square - 3.141d) < 0.001d);
        }

        [Fact]
        public void CircleSquareTest2()
        {
            var square = new Circle(5.7m).Square;

            Assert.True(Math.Abs(square - 102.07d) < 0.001d);
        }

        [Fact]
        public void CircleSquareTest3()
        {
            var square = new Circle(4m).Square;

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
                _ = new Circle(-1);
            });
        }

        /// <summary>
        /// Тесты площади
        /// </summary>
        [Fact]
        public void TriangleSquareTest1()
        {
            var square = new Triangle(4, 5, 3).Square;

            Assert.Equal(6d, square);
        }

        [Fact]
        public void TriangleSquareTest2()
        {
            var square = new Triangle(4, 10, 8).Square;

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
                _ = new Triangle(4, 4, 10);
            });
        }

        [Fact]
        public void TriangleRightTest1()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight);
        }

        [Fact]
        public void TriangleRightTest2()
        {
            Assert.False(new Triangle(3, 6, 5).IsRight);
        }

        /// <summary>
        /// Тесты идентичности
        /// </summary>
        [Fact]
        public void CircleEqualsTest1()
        {
            var circle1 = new Circle(10);
            var circle2 = new Circle(10);

            Assert.True(circle1 == circle2);
            Assert.False(circle1 != circle2);
            Assert.True(circle1.Equals(circle2));
        }

        [Fact]
        public void CircleEqualsTest2()
        {
            var circle1 = new Circle(8);
            var circle2 = new Circle(10);

            Assert.False(circle1 == circle2);
            Assert.True(circle1 != circle2);
            Assert.True(!circle1.Equals(circle2));
        }

        [Fact]
        public void TriangleEqualsTest1()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(3, 4, 5);

            Assert.True(triangle1 == triangle2);
            Assert.False(triangle1 != triangle2);
            Assert.True(triangle1.Equals(triangle2));
        }


        [Fact]
        public void TriangleEqualsTest2()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var triangle2 = new Triangle(3, 4, 6);

            Assert.True(triangle1 != triangle2);
            Assert.False(triangle1 == triangle2);
            Assert.False(triangle1.Equals(triangle2));
        }
    }
}
