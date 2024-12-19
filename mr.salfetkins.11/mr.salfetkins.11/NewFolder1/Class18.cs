using System.Linq;

public class StringHelper
{
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    public static string Reverse(string input)
    {
        return new string(input.Reverse().ToArray());
    }
}