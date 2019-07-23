using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
    public class Rectangle : IShape
    {
        double Length;
        double Breadth;

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public double Area()
        {
            return this.Length * this.Breadth;
        }

    }
}
