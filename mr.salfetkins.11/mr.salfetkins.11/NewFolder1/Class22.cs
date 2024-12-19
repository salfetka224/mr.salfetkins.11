public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public class Point3D : Point
    {
        public double Z { get; set; }
    }
}