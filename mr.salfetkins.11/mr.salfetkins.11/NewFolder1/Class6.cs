public class Database
{
    public static bool IsConnected { get; private set; }

    public static void Connect()
    {
        // Имитация подключения
        IsConnected = true;
    }
}