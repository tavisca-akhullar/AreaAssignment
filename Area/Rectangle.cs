using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Rectangle : IShape
    {
        private double _length { set; get; }
        private double _breadth { set; get; }

        public Rectangle(double length, double breadth)
        {
            _length = length;
            _breadth = breadth;
        }

        public double Area()
        {
            return this._length * this._breadth;
        }

    }
}
