using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryCalculatorLib.Models
{
    public class CircleMath( double radius ) : Shape
    {
        // Property - read and write
        public double Radius { get; set; } = radius; // Radius = radius

        // Calculates the area of a circle with the given radius.
        public override double Area => Math.PI * Radius * Radius; // Read only property


        // Calculates the radius of a circle whose area is the given factor times the area of the circle with the given radius.
        public override void Scale( double factor ) { Radius *= Math.Sqrt(factor); }


        public override string ToString() => $"CIRCLE\nNew radius: {Radius}";

    }

}
