namespace who_are_you;

internal static class WhoAreYou
{
    private static void Main()
    {
        Console.WriteLine("Whats your name?");
        var name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
        Console.WriteLine("how old are you?");
        // Will throw an exception if text is entered...
        var age = int.Parse(Console.ReadLine()!);
        Console.WriteLine("So your name is {0} and you are {1} years old! ", name, age);
    }
}