using System;

public abstract class Shapee
{
    public abstract double GetArea();

    public static string GetShapeType(Shape shape)
    {
        return shape.GetType().Name;
    }
}

public class Circlee : Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}