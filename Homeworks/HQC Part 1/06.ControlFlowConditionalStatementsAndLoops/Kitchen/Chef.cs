namespace Kitchen
{
    using Models;

    public class Chef
    {
        public void Cook()
        {
            Bowl bowl;
            bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            var bowl = new Bowl();

            return bowl;
        }

        private Potato GetPotato()
        {
            var potato = new Potato();

            return potato;
        }

        private Carrot GetCarrot()
        {
            var carrot = new Carrot();

            return carrot;
        }

        private void Peel(Vegetable vegetable)
        {
        }

        private void Cut(Vegetable potato)
        {            
        }        
    }
}
