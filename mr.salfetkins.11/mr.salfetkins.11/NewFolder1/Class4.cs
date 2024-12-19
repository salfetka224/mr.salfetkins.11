using System;

public class Geometry
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double CalculateDistance(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }
    }
}