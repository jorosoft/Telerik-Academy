namespace Kitchen.Models
{
    using System.Collections.Generic;

    public class Bowl
    {
        private IList<Vegetable> content = new List<Vegetable>();

        public void Add(Vegetable vegetable)
        {
            this.content.Add(vegetable);
        }
    }
}
