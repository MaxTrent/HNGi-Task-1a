using System;

namespace name
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hello User, input your name");
            name = Console.ReadLine();
            Console.WriteLine("Your name is {0}", name);
            Console.ReadKey();
        }
    }
}
