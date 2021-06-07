using AccessModifiers.Library;
using System;

namespace AccessModifiers.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            Console.WriteLine(l.title);

            Console.WriteLine("Hello World!");
        }
    }
}
