using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number: \n");
                int num = int.Parse(Console.ReadLine());
                isPrime(num);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid number!");
            }
            Console.ReadLine();
        }

        private static void isPrime(int num)
        {
            int flag = 0;
            for(int i=2; i <= num/2; i++)
            {
                if(num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("\n{0} is a prime number.", num);
            }
            else
            {
                Console.WriteLine("\n{0} is not a prime number.", num);
            }
        }
    }
}
