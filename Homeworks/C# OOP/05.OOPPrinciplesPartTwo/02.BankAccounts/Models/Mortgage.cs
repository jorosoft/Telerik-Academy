namespace _02.BankAccounts.Models
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal ballance, decimal interestRate) 
            : base(customer, ballance, interestRate)
        {
        }

        public override decimal CalculateInterestAmmount(int months)
        {
            var interest = months * this.InterestRate;
            if (this.Owner.CustomerType == (CustomerType)0)
            {
                if (months <= 6)
                {
                    return interest / 2;
                }
                else
                {
                    return (6 * this.InterestRate / 2) + ((months - 6) * this.InterestRate);
                }
            }

            if (this.Owner.CustomerType == (CustomerType)1)
            {
                if (months <= 12)
                {
                    return interest / 2;
                }
                else
                {
                    return (12 * this.InterestRate / 2) + ((months - 12) * this.InterestRate);
                }
            }

            return interest;
        }
    }
}
