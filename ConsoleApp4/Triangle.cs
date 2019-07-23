using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Triangle : IShape
    {
        double Length;
        double Base;
        double Height;

        public Triangle(double length, double breadth, double height)
        {
            Length = length;
            Base = breadth;
            Height = height;
        }

        public double Area()
        {
            return (this.Height * this.Base) / 2;
        }
    }
}
