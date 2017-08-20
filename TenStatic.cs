using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenStatic
{
    class Program
    {
        static int count = 0;
        public Program()
        {
            count += 1;
        }
        static void Main(string[] args)
        {
            new Program();
            new Program();
            new Program();
            Console.WriteLine("The number of objects created are {0}", count);
            Console.ReadLine();
        }
    }
}
