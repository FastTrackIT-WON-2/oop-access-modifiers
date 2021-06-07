using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Library
{
    class Ultrabook : Laptop
    {
        void DetachScreen()
        {
            // no access because title is private to Laptop
            Console.WriteLine(title);
            
        }
    }
}
