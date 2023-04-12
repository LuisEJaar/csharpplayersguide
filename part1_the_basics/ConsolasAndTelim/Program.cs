internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bread is Ready");
        Console.WriteLine("Who is the bread for?");
        string? name;
        name = Console.ReadLine();
        Console.WriteLine("Noted: " + name + " got bread.");
    }
}