using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        int p = int.Parse(Console.ReadLine()?? "0");
        int y = int.Parse(Console.ReadLine()?? "0");
        Console.WriteLine($"Sum nambers x: {p} and y: {y} = {p+y}");
    }
}