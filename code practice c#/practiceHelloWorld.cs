using System;

namespace practiceHelloWorld
{
    class helloClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! \nWrite Your Name Here: ");
            
            string name = Console.ReadLine();

            Console.WriteLine(name + " is super duper dope. Cool.");
        }
    }
}