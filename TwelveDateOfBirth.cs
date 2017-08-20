using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDateOfBirth
{
    struct DateOfBirth
    {
        public string name;
        public int date;
        public int month;
        public int yearOfBirth;
        public DateOfBirth(string name, int date, int month, int yearOfBirth)
        {
            this.name = name;
            this.date = date;
            this.month = month;
            this.yearOfBirth = yearOfBirth;
        }

        public void Display(string name, int date, int month, int yearOfBirth)
        {
            Console.WriteLine("\n{0}'s date of birth is {1}/{2}/{3}", name, date, month, yearOfBirth);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            try {
                string ch = null;
                Console.WriteLine("Enter the number of students you have to register: \n");
                int size = int.Parse(Console.ReadLine());
                DateOfBirth[] obj = new DateOfBirth[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("\nEnter the details of student {0}: \n", i + 1);
                    Console.WriteLine("\nEnter the name of student: \n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter the date of birth: \n");
                    int date = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter the month of birth: \n");
                    int month = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter the year of birth: \n");
                    int yearOfBirth = int.Parse(Console.ReadLine());
                    obj[i] = new DateOfBirth(name, date, month, yearOfBirth);
                    Console.WriteLine("\n------------------------------------------------------------------");
                }
                Console.WriteLine("\n---------------------DATE OF BIRTH SYSTEM------------------------");
                do
                {
                    int index = -1;
                    Console.WriteLine("\nEnter the name of the student: \n");
                    string name = Console.ReadLine();
                    for (int i = 0; i < size; i++)
                    {
                        if (name.Equals(obj[i].name))
                        {
                            index = i;
                        }
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("\nSorry student has not yet registered!");
                    }
                    else
                    {
                        obj[index].Display(obj[index].name, obj[index].date, obj[index].month, obj[index].yearOfBirth);
                    }
                    Console.WriteLine("\nDo you want to continue? (Y/N)");
                    ch = Console.ReadLine();
                } while (!ch.Equals("NO") && !ch.Equals("no") && !ch.Equals("n") && !ch.Equals("N"));
            }
            catch(Exception e)
            {
                Console.WriteLine("\n"+ e.Message);
            }
            Console.ReadLine();
        }
    }
}
