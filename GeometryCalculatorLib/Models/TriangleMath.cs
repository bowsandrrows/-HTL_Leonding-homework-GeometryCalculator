using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryCalculatorLib.Models
{
    public class TriangleMath( double baseLength, double height ) : Shape
    {

        // Properties
        public double BaseLength { get; set; } = baseLength;
        public double Height { get; set; } = height;




        // Calculates the area of a triangle with the given base and height.
        public override double Area => BaseLength * Height / 2;

        //  Calculates the base and height of a triangle whose area is the given factor times the area of
        //  the triangle with the given base and height. The aspect ratio (base/height) must be preserved.
        public override void Scale( double factor )
        {
            BaseLength *= Math.Sqrt( factor );
            Height *= Math.Sqrt( factor );
        }

        public override string ToString() => $"TRIANGLE\nNew base value = {BaseLength}\nNew height = {Height}";
    }
}