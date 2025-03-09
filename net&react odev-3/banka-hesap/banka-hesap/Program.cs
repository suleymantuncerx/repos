using System;
using System.Globalization;

namespace BankaHesap
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountHolder, decimal balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void CalculateInterest()
        {
            
        }
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, decimal balance)
            : base(accountHolder, balance)
        {
        }

        public override void CalculateInterest()
        {
            decimal interest = Balance * 0.3m;
            CultureInfo trCulture = new CultureInfo("tr-TR");
            trCulture.NumberFormat.CurrencySymbol = "₺";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Vadeli hesap faizi: {interest.ToString("C2", trCulture)}");
        }
    }

    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolder, decimal balance)
            : base(accountHolder, balance)
        {
        }

        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            SavingsAccount vadeliHesap = new SavingsAccount("Süleyman Mert Tuncer", 4000m);
            vadeliHesap.CalculateInterest();

            CheckingAccount vadesizHesap = new CheckingAccount("Mert Tuncer", 1000m);
            vadesizHesap.CalculateInterest();
        }
    }
}