using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeProblem
{
    class Circle : Shape
    {
        double radius;
        //overriding properties
        public override double Width
        {
            get { return radius; }
            set { radius = value; }
        }
        public override double Height
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double rad)
        {
            radius = rad;
        }
        //overriding method 
        public override double Calculatesurface()
        {
            return (3.14 * Width * Height);
        }

        public override string ToString()
        {
            double area = Calculatesurface();
            return ("Area of the Circle (3.14*" + Width + "*" + Height + ") : " + area.ToString() + " meter square");
        }
    }
}
