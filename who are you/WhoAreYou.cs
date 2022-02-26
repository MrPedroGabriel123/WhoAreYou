
namespace GettingInput
{
    class whoareyou
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("What´s your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine("how old are you?");
            var age = Console.ReadLine();
            Console.WriteLine($"oh, your name is {name} and you have {age} years old, nice :)! ");
            Console.WriteLine($"Are you having a nice day {name}? (yes/no)");
            string answer = Console.ReadLine()!;
              if (answer == "yes")
            {
                Console.WriteLine("Nice mate :D");
            }
            if (answer == "no")
            {
                Console.WriteLine("It will get better :D!");
            }
            Console.ReadLine();
        }
    }
}
