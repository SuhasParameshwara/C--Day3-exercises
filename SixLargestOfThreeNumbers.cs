using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixLargestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the three numbers: \n");
                int FirstNumber = int.Parse(Console.ReadLine());
                int SecondNumber = int.Parse(Console.ReadLine());
                int ThirdNumber = int.Parse(Console.ReadLine());
                int largest = largestNumber(FirstNumber, SecondNumber, ThirdNumber);
                Console.WriteLine("The largest of {0}, {1} and {2} are {3}", FirstNumber, SecondNumber, ThirdNumber, largest);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Number!");
            }
            Console.ReadKey();
        }

        private static int largestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            else if(secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else
            {
                return thirdNumber;
            }
        }
    }
}
