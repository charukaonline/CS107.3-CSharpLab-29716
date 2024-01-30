using System;

namespace ATM
{
    class Program
    {
        static decimal balance = 0;

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome to the ATM machine!");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"Successfully deposited {amount:C}. New balance: {balance:C}");
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance. Withdrawal failed.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {balance:C}");
            }
        }
    }
}
