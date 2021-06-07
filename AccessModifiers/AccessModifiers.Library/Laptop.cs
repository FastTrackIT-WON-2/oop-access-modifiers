using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Library
{
    public class Laptop
    {
        public enum Color
        {
            Black,
            White,
            Gray
        }

        public string title;

        public void AddToCart()
        {
            Console.WriteLine($"Adding '{title}' to cart");
        }
    }
}
