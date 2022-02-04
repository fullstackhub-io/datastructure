
public static class Util
{
    public static void WriteDebug(string msg)
    {
        Console.WriteLine(msg);
        Console.WriteLine("================================================");
    }

    public static void WriteResult(string msg)
    {
        Console.WriteLine("________________________________________________");
        Console.WriteLine($"* Output: {msg} *");
        Console.WriteLine("________________________________________________");
    }

    public static void Spacer()
    {
        Console.WriteLine("");
        Console.WriteLine("");
    }

}