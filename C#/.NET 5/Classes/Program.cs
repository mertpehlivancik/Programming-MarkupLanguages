using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Mert", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
