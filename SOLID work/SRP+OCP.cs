using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_work
{
    interface IDiscount
    {
        double Apply(double amount);
    }
    class RegularDiscount : IDiscount
    {
        public double Apply(double amount) => amount * 0.9;
    }
    class PremiumDiscount : IDiscount
    {
        public double Apply(double amount) => amount * 0.8;
    }

    class DiscountCalculator
    {
        public double Calculate(IDiscount discount, double amount)
        {
            return discount.Apply(amount);
        }
    }
    internal class SRP_OCP
    {
        static void Main(string[] args)
        {
            DiscountCalculator calculator = new DiscountCalculator();
            Console.WriteLine(calculator.Calculate(new RegularDiscount(), 1000));
        }
    }
}
