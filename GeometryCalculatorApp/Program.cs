using GeometryCalculatorLib.Models;
using System.Drawing;

Console.WriteLine( "\tGEOMETRY CALCULATOR APP\n" );


List<string> Letters = [ "c", "r", "t" ];

static double parseInput( string input )
{
    // Checks if input is a number and converts if it is.
    while ( !double.TryParse( input, out double _ ) )
    {
        Console.WriteLine( $"\n{input} is not a number. Try again." );
        input = Console.ReadLine();
    }
    return double.Parse( input );
}

#region Prompt for First Letter

//double width = 0d, height = 0d, radius = 0d, baseLength = 0d;

Shape? shape = null;

while ( shape is null )
{
    // Type of the geometric figure
    Console.Write( "Enter a type of the geometric figure R/r for rectangle, C/c for circle, T/t for triangle: " );

    string? geometryFigure = Console.ReadLine();
    string firstLetter = geometryFigure!.ToLower().Trim();

    if ( !Letters.Contains( firstLetter ) )
    {
        Console.WriteLine( "\nINCORRECT VALUE INPUT. TRY AGAIN.\n" );
        continue;
    }
    else
    {
        Console.WriteLine();

        if ( firstLetter == "c" )
        {
            Console.WriteLine( "\tCALULATING RADIUS OF THE CIRCLE\n" );
            Console.Write( "Enter the radius: " );
            var radius = parseInput( Console.ReadLine()! );
            Console.WriteLine( "\t - - - -" );
            shape = new CircleMath( radius );
        }
        else if ( firstLetter == "r" )
        {

            Console.WriteLine( "\tCULULATING THE ARIA OF THE RECTANGLE\n" );
            Console.Write( "Enter the width: " );
            var width = parseInput( Console.ReadLine()! );
            Console.Write( "Enter the height: " );
            var height = parseInput( Console.ReadLine()! );
            Console.WriteLine( "\t - - - -" );
            shape = new RectangleMath( width, height );
        }
        else if ( firstLetter == "t" )
        {
            Console.WriteLine( "\tCULULATING THE BASE OF THE TRIANGLE\n" );
            Console.Write( "Enter the base width: " );
            var baseLength = parseInput( Console.ReadLine()! );
            Console.Write( "Enter the height: " );
            var height = parseInput( Console.ReadLine()! );
            Console.WriteLine( "\t - - - -" );
            shape = new TriangleMath( baseLength, height );
        }
        break;
    }
}
#endregion

#region Culculate Factor

Console.Write( "Enter the factor: " );
double factor = parseInput( Console.ReadLine()! );

Console.WriteLine( "\t - - - -" );
Console.WriteLine( $"Original area: {shape!.Area}" );

shape.Scale( factor );

Console.WriteLine( $"\n\tTHE NEW AREA OF THE {shape}" );
Console.WriteLine( $"Scaled by {factor} = {Math.Round( shape.Area, 2 )}" );


#endregion
