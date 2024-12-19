using System;

public class MathUtils
{
    public static int Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("n must be non-negative");
        return n == 0 ? 1 : n * Factorial(n - 1);
    }
}