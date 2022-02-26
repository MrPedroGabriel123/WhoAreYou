
namespace GettingInput
{
    class whoareyou
    {
        static void Main()
        { 
            Console.WriteLine("Whats your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine("how old are you?");
            var age = Console.ReadLine();
            Console.WriteLine($"oh, your name is {name} and you have {age} years old, nice :)! ");
            Console.WriteLine($"are you having a nice day {name}? (y/n)");



        }
    }
}