using System;
using Xunit;
using Area;

namespace AreaTest
{
    public class AreaTest
    {  
        [Fact]
        public void CircleArea()
        {
            Circle circle = new Circle(5);
            Assert.Equal(78.5,Math.Round(circle.Area(),1));
        }

        [Fact]
        public void SquareArea()
        {
            Square square = new Square(5);
            Assert.Equal(25.0, Math.Round(square.Area(),1));
        }

        [Fact]
        public void RectangleArea()
        {
            Rectangle rectangle = new Rectangle(5,8);
            Assert.Equal(40.0, Math.Round(rectangle.Area(),1));
        }

        [Fact]
        public void TriangleArea()
        {
            Triangle triangle = new Triangle(4,5,8);
            Assert.Equal(20.0, Math.Round(triangle.Area(),1));
        }
    }
}
