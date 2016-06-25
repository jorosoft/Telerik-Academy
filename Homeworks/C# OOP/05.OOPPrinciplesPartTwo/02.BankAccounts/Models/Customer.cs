namespace _02.BankAccounts.Models
{
    using System;

    public class Customer
    {
        private string fullName;

        public Customer(string fullName, CustomerType customerType)
        {
            this.FullName = fullName;
            this.CustomerType = customerType;
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            
            set
            {
                if (value.Trim() == string.Empty)
                {
                    throw new ArgumentOutOfRangeException("Name can't be empty!");
                }

                this.fullName = value.Trim();
            }
        }

        public CustomerType CustomerType { get; set; }
    }
}
