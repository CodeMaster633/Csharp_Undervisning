using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_Objektorientering.Opg3_0
{
    internal class Circle : Shape
    {
        public double radius;
        public Circle(double radius) : base() {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }
    }
}
