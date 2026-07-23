using System;
using System.Collections.Generic;
using System.Text;


namespace GeometryCalculatorLib.Models
{
    public class RectangleMath( double width, double height ) : Shape
    {
        // Properties
        public double Width { get; set; } = width; 
        public double Height { get; set; } = height;

        // Read-only Property. Calculates the area of a rectangle with the given width and height.
        public override double Area => Width * Height; // Read only

        // Calculates the width and height of a rectangle whose area is the given factor times the area of the rectangle with the given width and height. The aspect ratio (width/height) must be preserved.
        public override void Scale( double factor )
        {
            Width *= Math.Sqrt( factor ); 
            Height *= Math.Sqrt( factor );
        }

        public override string ToString() => $"RECTANGLE\n New width = {Width}\nNew height = {Height}";
    }
}
