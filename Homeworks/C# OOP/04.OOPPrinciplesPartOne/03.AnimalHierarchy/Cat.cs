namespace _03.AnimalHierarchy
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, SexType sex)
            :base(age, name, sex)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Miauuuuuuuu...");
        }
    }
}
