using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Square : IShape
    {
        private double _length { set; get; };

        public Square(double length)
        {
            _length = length;
        }

        public double Area()
        {
            return this._length * this._length;
        }
    }
}
