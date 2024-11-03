using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract class and inheritence
namespace OopsConcepts
{
    public class CurrentAccount:Account
    {
        public double balance;
        public double amount;

        public CurrentAccount(double balance, double amount)
        {
            this.balance = balance;
            this.amount = amount;
        }

        public override void Deposit()
        {
            balance = balance + amount;
            Console.WriteLine($"User has deposited {amount} and the Current account balance is {balance}");
        }

        public override void Withdraw()
        {

            if (balance > 0)
            {
                balance = balance - amount;
                Console.WriteLine($"User has withdrawn {amount} and the Current account balance is {balance}");
            }
            else
            {
                Console.WriteLine("User has Insufficient Account Balance");
            }
        }
    }
}

