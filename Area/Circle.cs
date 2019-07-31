using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Circle : IShape
    {
        private double _radius { get; set; }
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return 3.14 * this._radius * this._radius;
        }

    }
}
