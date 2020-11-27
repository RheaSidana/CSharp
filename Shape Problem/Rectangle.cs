using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2Quse1
{
    class Rectangle : Shape
    {
        //overriding properties
        public override double Width
        {
            get { return width; }
            set { width = value; }
        }
        public override double Height
        {
            get { return height; }
            set { height = value; }
        }

        //overriding method 
        public override double Calculatesurface()
        {
            return (Width * Height);
        }
        public override string ToString()
        {
            double area = Calculatesurface();
            return ("Area of the Rectangle (" + Width + "*" + Height + ") : " + area.ToString() + " meter square");
        }
    }
}