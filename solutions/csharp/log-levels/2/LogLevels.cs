static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');
        return logLine.Substring(colonIndex+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');
        return logLine.Substring(0,colonIndex).Trim('[',']').ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
    
}
