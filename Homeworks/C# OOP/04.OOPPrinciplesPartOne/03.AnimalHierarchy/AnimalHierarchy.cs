namespace _03.AnimalHierarchy
{
    using System;
    using System.Linq;

    internal class AnimalHierarchy
    {
        internal static void Main()
        {
            var cats = new Cat[]
            {
                new Cat(2, "Mimi", SexType.Female),
                new Cat(5, "Pipi", SexType.Female),
                new Cat(3, "Misho", SexType.Male),
                new Cat(7, "Moro", SexType.Male),
                new Cat(1, "Spaska", SexType.Female),
            };
            var dogs = new Dog[]
            {
                new Dog(0, "Balkan", SexType.Male),
                new Dog(5, "Djesa", SexType.Female),
                new Dog(2, "Lasi", SexType.Male)
            };
            var frogs = new Frog[]
            {
                new Frog(0, "Kvako", SexType.Male),
                new Frog(3, "Kircho", SexType.Male),
                new Frog(4, "Kika", SexType.Female),
                new Frog(2, "Kokorcho", SexType.Male)
            };
            var kittens = new Kitten[]
            {
                new Kitten(2, "Macii"),
                new Kitten(1, "Pisana")
            };
            var tomcats = new Tomcat[]
            {
                new Tomcat(3, "Misho")
            };
            Console.WriteLine("======== LIST OF CATS ========");
            PrintAnimalsGroup(cats);
            Console.WriteLine("======== LIST OF DOGS ========");
            PrintAnimalsGroup(dogs);
            Console.WriteLine("======== LIST OF FROGS ========");
            PrintAnimalsGroup(frogs);
            Console.WriteLine("======== LIST OF KITTENS ========");
            PrintAnimalsGroup(kittens);
            Console.WriteLine("======== LIST OF TOMCATS ========");
            PrintAnimalsGroup(tomcats);
        }

        internal static double GetAverageAgeOfGroup(Animal[] animals)
        {
            double averageAge = 0;
            averageAge = animals.Sum(a => a.Age) / (double)animals.Count();
            return averageAge;
        }

        internal static void PrintAnimalsGroup(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.Sex}) - {animal.Age} years old");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("AVERAGE AGE OF GROUP: {0:F1}", GetAverageAgeOfGroup(animals));
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }
}
