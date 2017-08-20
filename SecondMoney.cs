using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the principal amount: \n");
                float amount = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the rate of interest: \n");
                float interest = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of years: \n");
                float years = float.Parse(Console.ReadLine());
                float FinalAmount = calculateAmount(amount, interest, years);
                Console.WriteLine("The final amount is Rs. {0}", FinalAmount);

            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid number!");
            }
            Console.ReadLine();
        }

        private static float calculateAmount(float amount, float interest, float years)
        {
            float FinalAmount = (amount * interest * years) / 100;
            return FinalAmount;
        }
    }
}
