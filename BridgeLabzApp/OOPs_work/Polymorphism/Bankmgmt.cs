using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Polymorphism
{
    class Account
    {
        public string AccountHolder { get; set; }
        public double Bal { get; set; }
        public Account(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Bal = balance;
        }
        public virtual void Withdraw(double amount)
        {
            if (amount <= Bal)
            {
                Bal -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} successful. Remaining balance: {Bal:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"{AccountHolder}'s Current Balance: {Bal:C}");
        }
    }
    class SavingsAccount : Account
    {
        private const double MIN_BALANCE = 1000;

        public SavingsAccount(string holder, double balance)
            : base(holder, balance)
        {
        }

        // Override withdrawal rule: must maintain minimum balance
        public override void Withdraw(double amount)
        {
            if (Bal - amount < MIN_BALANCE)
            {
                Console.WriteLine($"Withdrawal denied for {AccountHolder}. Minimum balance of {MIN_BALANCE:C} must be maintained.");
            }
            else
            {
                Bal -= amount;
                Console.WriteLine($"{AccountHolder}: Withdrawal of {amount:C} successful. New balance: {Bal:C}");
            }
        }
    }
    class CurrentAccount : Account
    {
        private const double OVERDRAFT_LIMIT = 5000;

        public CurrentAccount(string holder, double balance)
            : base(holder, balance)
        {
        }

        // Override withdrawal rule: allows overdraft
        public override void Withdraw(double amount)
        {
            if (amount <= Bal + OVERDRAFT_LIMIT)
            {
                Bal -= amount;
                Console.WriteLine($"{AccountHolder}: Withdrawal of {amount:C} successful (Overdraft allowed). New balance: {Bal:C}");
            }
            else
            {
                Console.WriteLine($"{AccountHolder}: Withdrawal denied. Overdraft limit of {OVERDRAFT_LIMIT:C} exceeded!");
            }
        }
    }
    internal class Bankmgmt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bank Account System (Polymorphism Example) ===\n");

            
            Account acc1 = new SavingsAccount("Adithya", 5000);
            Account acc2 = new CurrentAccount("Jenson", 2000);

            acc1.DisplayBalance();
            acc1.Withdraw(4500); 
            acc1.Withdraw(3000); 
            acc1.DisplayBalance();

            Console.WriteLine();

            acc2.DisplayBalance();
            acc2.Withdraw(6000); 
            acc2.Withdraw(8000); 
            acc2.DisplayBalance();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
