using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Square : IShape
    {
        double Length;

        public Square(double length)
        {
            Length = length;
        }

        public double Area()
        {
            return this.Length * this.Length;
        }
    }
}
