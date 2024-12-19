using System;
using System.IO;

public class Settings
{
    public static string Language { get; set; }
    public static string Theme { get; set; }
    public static int FontSize { get; set; }

    public static void SaveSettings(string filename)
    {
        File.WriteAllText(filename, $"Language: {Language}\nTheme: {Theme}\nFont Size: {FontSize}\n");
    }

   
   
}
           