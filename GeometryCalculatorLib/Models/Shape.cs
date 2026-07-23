using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryCalculatorLib.Models
{ // Abstraction
    public abstract class Shape
    {
        public abstract double Area {  get; }

        public abstract void Scale( double factor );
    }
}
