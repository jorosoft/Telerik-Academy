namespace PersonCreator
{
    using Enumerations;
    using Models;

    internal class PersonCreator
    {
        public void MakePerson(int personAge)
        {
            Person person = new Person();
            person.Age = personAge;
            if (personAge % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = GenderType.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = GenderType.Female;
            }
        }

        internal static void Main()
        {
        }
    }
}
