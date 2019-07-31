using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Triangle : IShape
    {
      private  double _length { set; get; }
        private double _base { set; get; }
        private double _height { set; get; }

        public Triangle(double length, double breadth, double height)
        {
            _length = length;
            _base = breadth;
            _height = height;
        }

        public double Area()
        {
            return (this._height * this._base) / 2;
        }
    }
}
