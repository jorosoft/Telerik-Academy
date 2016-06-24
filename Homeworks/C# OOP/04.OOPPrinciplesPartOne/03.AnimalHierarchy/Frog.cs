namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, SexType sex)
            :base(age, name, sex)
        {
        }

        public void Sound()
        {
            Console.WriteLine("Kvak kvak...");
        }
    }
}
