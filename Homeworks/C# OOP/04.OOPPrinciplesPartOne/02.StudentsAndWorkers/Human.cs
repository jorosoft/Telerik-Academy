namespace _02.StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Name length can't be smaller than 1 symbol!");
                }

                this.firstName = value.Trim();
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Name length can't be smaller than 1 symbol!");
                }

                this.lastName = value.Trim();
            }
        }
    }
}
