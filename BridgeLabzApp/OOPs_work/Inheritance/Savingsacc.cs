using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.OOPs_work.Inheritance
{
    class Account
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {Balance:C}");
        }
    }
    class SavingsAccount : Account
    {
        public void AddInterest(double rate)
        {
            double interest = Balance * rate / 100;
            Balance += interest;
            Console.WriteLine($"Interest added: {interest:C}. Balance after interest: {Balance:C}");
        }
    }

    class PremiumSavingsAccount : SavingsAccount
    {
        public void OfferCashback(double cashback)
        {
            Balance += cashback;
            Console.WriteLine($"Cashback of {cashback:C} credited! Final Balance: {Balance:C}");
        }
    }
    internal class Savingsacc
    {
        static void Main(string[] args)
        {
            PremiumSavingsAccount acc = new PremiumSavingsAccount();
            acc.AccountHolder = "Jenson";
            acc.Deposit(10000);      // from Account
            acc.AddInterest(5);      // from SavingsAccount
            acc.OfferCashback(500);  // from PremiumSavingsAccount

            Console.WriteLine($"\nAccount Holder: {acc.AccountHolder}, Final Balance: {acc.Balance:C}");
            Console.ReadLine();
        }
    }
}
