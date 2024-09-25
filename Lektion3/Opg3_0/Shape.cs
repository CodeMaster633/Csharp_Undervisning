using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_0
{
    internal abstract class Shape
    {
        private double x;
        private double y;

        public double X {
            get{ return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Shape(double x, double y) {
            this.X = x;
            this.Y = y;
        }

        public Shape() : this(1, 1) { }

        public abstract double Area();

        public override string ToString()
        {
            return "Shape x og y: " + x + ", " + y;
        }

    }
}
