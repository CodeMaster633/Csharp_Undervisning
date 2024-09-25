using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_0
{
    internal class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public Rectangle(int x, int y, double Length, double Width) : base(x,y) {
            this.Length = Length;
            this.Width = Width;
        }
        public override double Area()
        {
            return Length*Width;
        }

        public override string ToString()
        {
            return "Shape x og y: " + X + ", " + Y + "\tLength og Width: "+Length + ", "+Width;
        }

    }
}
