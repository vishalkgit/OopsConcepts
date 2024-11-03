using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Abstract class and inheritence 1st question
namespace OopsConcepts
{


    abstract public class Account
    {
        public abstract void Deposit();
        public abstract void Withdraw();
    }


    public class SavingsAccount:Account
    {
        private double balance;
        private double amount;

        public SavingsAccount(double balance, double amount)
        {
            this.balance = balance;
            this.amount = amount;
        }

        public override void Deposit()
        {
            balance = balance + amount;
            Console.WriteLine($"User has deposited {amount} and the Savings account balance is {balance}");
        }

        public override void Withdraw()
        {
            if(balance>0)
            {
                balance=balance-amount;
                Console.WriteLine($"User has Withdrawn {amount} and the Savings account balance is {balance}");
            }
            else
            {
                Console.WriteLine("User has Insufficient Account Balance");
            }
        }




    }
}
