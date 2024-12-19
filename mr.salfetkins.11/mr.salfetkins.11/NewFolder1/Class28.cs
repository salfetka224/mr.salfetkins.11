using System;

public class RandomNumberGenerator
{
    private static Random _random = new Random();

    public static int GenerateRandomNumber(int min, int max)
    {
        return _random.Next(min, max);
    }
}