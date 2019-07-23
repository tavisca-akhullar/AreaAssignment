using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Circle : IShape
    {
         double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return 3.14 * this.Radius * this.Radius;
        }

    }
}
