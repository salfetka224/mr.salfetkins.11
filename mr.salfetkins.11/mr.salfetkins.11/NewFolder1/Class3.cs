public class Car
{
    public Engine CarEngine { get; set; }

    public class Engine
    {
        public int Power { get; set; }
        public double Volume { get; set; }
    }
}