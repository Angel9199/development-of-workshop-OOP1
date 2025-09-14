using   Heritagel.ibr;
using System.Drawing;

var circle = new Circle(nameof(Circle), 5);
var square = new Square(nameof(Square), 10);
var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
var kite = new Kite(nameof(Kite), 7, 6, 10, 5);
var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790);
var parallelogram = new Parallelogram(nameof(Parallelogram), 14.65, 65.47, 23.69);
var triangle = new Triangle(nameof(Triangle), 45.56, 12.30, 27.90, 15);
var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 25);

var figures = new List<GeometricFigure>()
{
    circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze
};

foreach (var figure in figures)
{
    Console.WriteLine(figure);
}

