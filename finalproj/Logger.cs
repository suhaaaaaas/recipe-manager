
public class Logger
{
    public void LogInfo(string message)
    {
        Console.WriteLine($"Info: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"Error: {message}");
    }

    public void LogWarning(string message)
    {
        Console.WriteLine($"Warning: {message}");
    }
}
