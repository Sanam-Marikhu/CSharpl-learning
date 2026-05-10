using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13
{
    class BankAccount
    {
        private double balance;
        public  double Balance
        {
            get { return balance; }

            set
            {
                if (value >=0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Invalid balance.");
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b=new BankAccount();
            Console.Write("Enter Balance:");
            b.Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your Balance is:"+b.Balance);
        }
    }
}
