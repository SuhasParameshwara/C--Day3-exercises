using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightSwap
{
    class @Integer
    {
        public void swap(ref float numOne, ref float numTwo)
        {
            numOne = numOne + numTwo;
            numTwo = numOne - numTwo;
            numOne = numOne - numTwo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                @Integer obj = new Integer();
                Console.WriteLine("Enter the first number: \n");
                float NumOne = float.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the second number: \n");
                float NumTwo = float.Parse(Console.ReadLine());
                Console.WriteLine("\nBefore Swapping of two numbers NumOne = {0}, NumTwo = {1}", NumOne, NumTwo);
                obj.swap(ref NumOne, ref NumTwo);
                Console.WriteLine("\nAfter Swapping of two numbers NumOne = {0}, NumTwo = {1}", NumOne, NumTwo);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadLine();
        }
    }
}
