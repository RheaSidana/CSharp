using System;
using System.Collections.Generic;
using System.Text;

namespace Ass2Quse1
{
    abstract class Shape
    {
        protected double width, height;
        public abstract double Width
        {
            get;set;
        }
        public abstract double Height
        {
            get;set;
        }
        public abstract double Calculatesurface();
    }
}