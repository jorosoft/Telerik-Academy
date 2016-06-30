namespace _04.PersonClass
{
    using System;

    internal class PersonClass
    {
        internal static void Main()
        {
            var personOne = new Person("Gruio Gruev", 21);
            var personTwo = new Person("Minka Vylkova", 18);
            var personThree = new Person("Sasho Petrov");
            var personFour = new Person("Maria Petrova", 44);
            var personFive = new Person("Kiro Kirov");
            Console.WriteLine("=========== TEST PERSONS ===========");
            Console.WriteLine(personOne.ToString());
            Console.WriteLine(personTwo.ToString());
            Console.WriteLine(personThree.ToString());
            Console.WriteLine(personFour.ToString());
            Console.WriteLine(personFive.ToString());
            Console.WriteLine("====================================");
        }
    }
}
