using System;
using System.IO;

public class Logger
{
    public static void Log(string message)
    {
        File.AppendAllText("log.txt", message + Environment.NewLine);
    }
}