using Heritagel.ibr;

namespace Heritagel.ibr
{
    public abstract class GeometricFigure
    {
            public string Name { get; set; }

            public GeometricFigure(string name)
            {
                Name = name;
            }

            public abstract double GetArea();
            public abstract double GetPerimeter();

            public override string ToString()
            {
                return $"{Name,-13} => Area......: {GetArea():N5}     Perimeter: {GetPerimeter():N5}";
            }
        }

    }
public class Circle : GeometricFigure
{
    public double R { get; set; }

    public Circle(string name, double r) : base(name) => R = r;

    public override double GetArea() => Math.PI * R * R;
    public override double GetPerimeter() => 2 * Math.PI * R;
}

public class Square : GeometricFigure
{
    public double A { get; set; }

    public Square(string name, double a) : base(name) => A = a;

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;
}

public class Rhombus : GeometricFigure
{
    public double A, D1, D2;

    public Rhombus(string name, double a, double d1, double d2) : base(name) => (A, D1, D2) = (a, d1, d2);

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 4 * A;
}

public class Kite : GeometricFigure
{
    public double A, B, D1, D2;

    public Kite(string name, double a, double b, double d1, double d2) : base(name) => (A, B, D1, D2) = (a, b, d1, d2);

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 2 * (A + B);
}

public class Rectangle : GeometricFigure
{
    public double A, B;

    public Rectangle(string name, double a, double b) : base(name) => (A, B) = (a, b);

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);
}

public class Triangle : GeometricFigure
{
    public double A, B, C, H;

    public Triangle(string name, double a, double b, double c, double h) : base(name) => (A, B, C, H) = (a, b, c, h);

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;
}

public class Trapeze : GeometricFigure
{
    public double A, B, C, D, H;

    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name) => (A, B, C, D, H) = (a, b, c, d, h);

    public override double GetArea() => ((B + D) * H) / 2;
    public override double GetPerimeter() => A + B + C + D;
}
