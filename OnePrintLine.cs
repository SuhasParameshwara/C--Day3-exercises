using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePrintLine
{
    class Program
    {
        private static string PrintLine(int num)
        {
            string str = new string('*', num);
            Console.WriteLine(str);
            return str;
        }
        static void Main(string[] args)
        {
            PrintLine(20);
            Console.ReadLine();
        }

    }
}
