namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats is your name?");
        var name = Console.ReadLine();
        var currentData = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentData:d} at {currentData:t}!"); // d = day, t = time
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true); // aguarda a entrada do usuário.
    }
}
