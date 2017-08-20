using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineBank
{
    class Bank
    {
        public string DepositorName;
        public string AccountNumber;
        public string TypeOfAccount;
        public int BalanceAmount;
        public Bank(string DepositorName, string AccountNumber, string TypeOfAccount, int BalanceAmount)
        {
            this.DepositorName = DepositorName;
            this.AccountNumber = AccountNumber;
            this.TypeOfAccount = TypeOfAccount;
            this.BalanceAmount = BalanceAmount;
        }
        public int Deposit(string DepositorName, int BalanceAmount)
        {
            Console.WriteLine(BalanceAmount);
            Console.WriteLine("\nEnter the amount to deposit: \n");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCurrent Balance: "+ (BalanceAmount + amount));
            return BalanceAmount + amount;
        }
        public int Withdraw(string DepositorName, int BalanceAmount)
        {
            Console.WriteLine("\nCurrent Balance: {0}",BalanceAmount);
            Console.WriteLine("\nEnter the amount to withdraw: \n");
            int amount = int.Parse(Console.ReadLine());
            if(amount > BalanceAmount)
            {
                Console.WriteLine("\nLow Balance!");
            }
            else
            {
                Console.WriteLine("\nCurrent Balance : " + (BalanceAmount - amount));
                BalanceAmount =  BalanceAmount - amount;
            }
            return BalanceAmount;
        }

        public void Display(string depositorName, int balanceAmount)
        {
            Console.WriteLine("\nName : " + depositorName);
            Console.WriteLine("\nCurrent Balance : " + balanceAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                string ch = null;
                Console.WriteLine("------------------BANK SYSTEM--------------------");
                Console.WriteLine("\nEnter the number of employees you want to register: \n");
                int size = int.Parse(Console.ReadLine());
                Bank[] obj = new Bank[size];
                string name = null;
                string TempName = null;
                int index = -1;
                try {
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine("\nEnter the employee {0} details: \n", i + 1);
                        Console.WriteLine("\nEnter the name of the employee: \n");
                        name = Console.ReadLine();
                        Console.WriteLine("\nEnter the account number: \n");
                        string AccountNumber = Console.ReadLine();
                        Console.WriteLine("\nEnter the type of account: \n");
                        string TypeOfAccount = Console.ReadLine();
                        Console.WriteLine("\nEnter the balance amount: \n");
                        int BalanceAmount = int.Parse(Console.ReadLine());
                        obj[i] = new Bank(name, AccountNumber, TypeOfAccount, BalanceAmount);
                    }
                    Console.WriteLine("\n----------------------SUCCESSFULLY REGISTERED!---------------------");
                    Console.WriteLine("\n----------------------BANK DATABASE-----------------------------");
                    do
                    {
                        Console.WriteLine("\n1. Deposit\n2. Wtihdraw\n3. Display Information");
                        Console.WriteLine("\nEnter your choice: \n");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("\nEnter the name of the depositor: \n");
                                TempName = Console.ReadLine();
                                index = -1;
                                for (int i = 0; i < size; i++)
                                {
                                    if (TempName.Equals(obj[i].DepositorName))
                                    {
                                        index = i;
                                    }
                                }
                                if (index == -1)
                                {
                                    Console.WriteLine("\nSorry the depositor name has not been registered!");
                                }
                                else
                                {
                                    obj[index].BalanceAmount = obj[index].Deposit(obj[index].DepositorName, obj[index].BalanceAmount);
                                }
                                break;
                            case 2:
                                Console.WriteLine("\nEnter the name of the depositor: \n");
                                TempName = Console.ReadLine();
                                index = -1;
                                for (int i = 0; i < size; i++)
                                {
                                    if (TempName.Equals(obj[i].DepositorName))
                                    {
                                        index = i;
                                    }
                                }
                                if (index == -1)
                                {
                                    Console.WriteLine("\nSorry the depositor name has not been registered!");
                                }
                                else
                                {
                                    obj[index].BalanceAmount = obj[index].Withdraw(obj[index].DepositorName, obj[index].BalanceAmount);
                                }
                                break;
                            case 3:
                                Console.WriteLine("\nEnter the name of the depositor: \n");
                                TempName = Console.ReadLine();
                                index = -1;
                                for (int i = 0; i < size; i++)
                                {
                                    if (TempName.Equals(obj[i].DepositorName))
                                    {
                                        index = i;
                                    }
                                }
                                if (index == -1)
                                {
                                    Console.WriteLine("\nSorry the depositor name has not been registered!");
                                }
                                else
                                {
                                    obj[index].Display(obj[index].DepositorName, obj[index].BalanceAmount);
                                }
                                break;
                            default: break;
                        }
                        Console.WriteLine("\nDo you want to continue? (Y/N)");
                        ch = Console.ReadLine();
                    } while (!ch.Equals("N") && !ch.Equals("n") && !ch.Equals("NO") && !ch.Equals("no"));

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
