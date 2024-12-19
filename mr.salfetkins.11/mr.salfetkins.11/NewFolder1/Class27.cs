using System;

public class NetworkConfig
{
    public static string IPAddress { get; set; }
    public static string SubnetMask { get; set; }
    public static string Gateway { get; set; }

    public static void DisplaySettings()
    {
        Console.WriteLine($"IP Address: {IPAddress}");
        Console.WriteLine($"Subnet Mask: {SubnetMask}");
        Console.WriteLine($"Gateway: {Gateway}");
    }
}