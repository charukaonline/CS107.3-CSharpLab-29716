using System;

namespace BankAccountApp
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.AccountNumber = "123456789";
            account.Balance = 1500;

            decimal depositAmount = 500;
            account.Deposit(depositAmount);

            Console.WriteLine("Updated Balance: $" + account.Balance);
        }
    }
}
