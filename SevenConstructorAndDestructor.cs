using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenConstructorAndDestructor
{
    class Number
    {
        public Number()
        {
            Console.WriteLine("\nObject is created.");
            Console.WriteLine("\nClick enter key to destroy the object!");
        }
        ~Number()
        {
            Console.WriteLine("\nObject is destroyed.");
            Console.ReadLine();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Click enter key to create an object!");
            Console.ReadLine();
            Number obj = new Number();
            obj = null;
            Console.ReadLine();
        }
    }
}
