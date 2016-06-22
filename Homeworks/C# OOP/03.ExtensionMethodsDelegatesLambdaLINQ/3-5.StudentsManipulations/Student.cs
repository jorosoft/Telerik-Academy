namespace _3_5.StudentsManipulations
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

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
                    throw new ArgumentException("First name size must be large than 0");
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
                    throw new ArgumentException("Last name size must be large than 0");
                }

                this.lastName = value.Trim();
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age can't be smaller than 0");
                }

                this.age = value;
            }
        }
    }
}
