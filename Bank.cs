using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Bank
    {
        private double balance;
        private double amount;

        public Bank()
        {
            balance = 45000;
        }

        public void Deposit()
        {
            Console.WriteLine("Enter the amount to deposit");
            double amount = Convert.ToDouble(Console.ReadLine());
            balance = balance + amount;
            Console.WriteLine($"The users total balance is {balance}");
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to withdraw");
            double amount = Convert.ToDouble(Console.ReadLine());
            balance = balance - amount;
            Console.WriteLine("The users total balance is"+balance);
        }

        public void GetBalance()
        {
            Console.WriteLine( $"Users total balance is" + balance);
        }


    }
}
