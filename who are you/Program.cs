
namespace GettingInput
{
    class whoareyou
    {
        static void Main()
        {
            Console.WriteLine("Whats your name?");
            var nome = Console.ReadLine();
            Console.WriteLine($"Hello, {nome}!");
            Console.WriteLine("how old are you?");
            var idade = Console.ReadLine();
            Console.WriteLine($"oh, your name is {nome} and you have {idade} years old, nice :)! ");
            
        }
    }
}