using System;

public class Outer
{
    private int _value = 42;

    public class Inner
    {
        public void PrintOuterValue(Outer outer)
        {
            Console.WriteLine(outer._value); // Доступ к приватному полю Outer
        }
    }
}