namespace _02.StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int grade)
            : this(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Invalid value of grade!"); 
                }

                this.grade = value;
            }
        }
    }
}
