namespace _03.AnimalHierarchy
{
    using System;

    public class Animal
    {
        private int age;
        private string name;
        
        public Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Animal(int age, string name, SexType sex)
            : this(age, name)
        {
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be negative number!");
                }

                this.age = value;
            }
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
                    throw new ArgumentException("Name length can't be smaller than 1 symbol!");
                }

                this.name = value.Trim();
            }
        }

        public SexType Sex { get; set; }
    }
}
