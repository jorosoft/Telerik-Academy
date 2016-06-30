namespace _04.PersonClass
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentOutOfRangeException("Name can't be smaller than 1 symbol!");
                }

                this.name = value.Trim();
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can't be negative!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return $"{this.Name} - unspecified age";
            }

            return $"{this.Name} - {this.Age} years old";
        }
    }
}
