using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Library
{
    class Person
    {
        void WorkWithALaptop()
        {
            Laptop l = new Laptop();
            
            // cannot access title here because is private to Laptop
            Console.WriteLine(l.title);
        }
    }
}
