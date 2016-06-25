namespace _02.BankAccounts
{
    using System;
    using _02.BankAccounts.Models;

    internal class BankAccounts
    {
        internal static void Main()
        {
            var banc = new Account[]
            {
                new Deposit(new Customer("Pencho Penchev", CustomerType.individual), 20.55m, 2.15m),
                new Loan(new Customer("Alabala OOD", CustomerType.company), 120000m, 1.22m),
                new Mortgage(new Customer("Kiro Kirov", CustomerType.individual), 2500.66m, 3.14m)
            };
            Console.WriteLine("============== INTEREST RATES FOR 24 MONTHS ==============");
            foreach (var account in banc)
            {
                Console.WriteLine($"{account.Owner.FullName} - {account.Ballance} lv. - {account.CalculateInterestAmmount(24)} interest");
            }
        }
    }
}
