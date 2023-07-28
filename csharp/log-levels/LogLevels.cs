using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Substring(logLine.IndexOf(":") + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
       return (logLine.Substring(1, (logLine.IndexOf(":") - 2))).ToLower();
    }

    public static string Reformat(string logLine)
    {
        int colonIndex = logLine.IndexOf(":");
        string logError = logLine.Substring(colonIndex + 1).Trim();
        string logLevel = (logLine.Substring(1, (colonIndex - 2))).ToLower();
        return logError + " " + $"({logLevel})";
    }
}
