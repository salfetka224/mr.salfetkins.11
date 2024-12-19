public class Counter
{
    public static int InitialValue { get; private set; }

    static Counter()
    {
        InitialValue = 10;
    }
}
