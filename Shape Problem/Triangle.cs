using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2Quse1
{
    class Triangle : Shape
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
            return ((Width*Height)/2);
        }

        public override string ToString()
        {
            double area = Calculatesurface();
            return ("Area of the Triangle ("+Width+"*"+Height+"/2) : "+area.ToString()+" meter square");
        }
    }
}