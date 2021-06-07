using AccessModifiers.Library;
using System;

namespace AccessModifiers.Terminal
{
    class Notebook : Laptop
    {
        void DoWork()
        {
            // cannot access title here because is private to Laptop
            Console.WriteLine(title);
        }
    }
}
