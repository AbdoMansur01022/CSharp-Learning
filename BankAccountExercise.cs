

using System;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Abdo");
            acc1.Deposit(1000);
            acc1.CheckBalance();

            Console.ReadKey(); 
        }
    } 
    
    public class BankAccount
    {
        public string AccountHolder;
        public double Balance;

        public BankAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
            Balance = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}