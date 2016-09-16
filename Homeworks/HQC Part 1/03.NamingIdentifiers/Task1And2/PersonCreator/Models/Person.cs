namespace PersonCreator.Models
{
    using Enumerations;

    public class Person
    {
        public GenderType Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
