internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What kind of thing are we talking about?");
        string a = Console.ReadLine(); /* Name */
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine(); /* Description */
        string c = "of doom"; // label
        string d = "3000"; // model
        Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
    }

    //Question Answer: 
    //Write better variable names
}