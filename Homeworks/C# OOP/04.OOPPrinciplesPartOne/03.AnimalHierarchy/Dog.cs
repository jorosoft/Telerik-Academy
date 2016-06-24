namespace _03.AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, SexType sex)
            :base(age, name, sex)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Bau bauuuuuuuuuu...");
        }
    }
}
