using System;

namespace BrianStiner_C_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            
            Console.WriteLine("Give me your name.");
            name = Console.ReadLine();

            Console.WriteLine(&"Welcome to the jungle, {name}! ");

        }
    }
}