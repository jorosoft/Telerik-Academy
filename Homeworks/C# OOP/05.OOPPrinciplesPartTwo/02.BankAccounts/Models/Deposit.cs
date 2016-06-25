namespace _02.BankAccounts.Models
{
    using System;

    public class Deposit : Account
    {
        public Deposit(Customer customer, decimal ballance, decimal interestRate) 
            : base(customer, ballance, interestRate)
        {
        }

        public override decimal CalculateInterestAmmount(int months)
        {
            if (this.Ballance > 0 && this.Ballance < 1000)
            {
                return 0;
            }

            return months * this.InterestRate;
        }

        public void DrawMoney(decimal ammount)
        {
            if (ammount > this.Ballance)
            {
                throw new ArgumentOutOfRangeException("Insufficient ballance for this operation!");
            }

            this.Ballance -= ammount;
        }
    }
}
