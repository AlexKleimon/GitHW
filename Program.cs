using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine()?? "0");
        int y = int.Parse(Console.ReadLine()?? "0");
        Console.WriteLine($"Multi nambers x: {x} and y: {y} = {x*y}");
    }
}