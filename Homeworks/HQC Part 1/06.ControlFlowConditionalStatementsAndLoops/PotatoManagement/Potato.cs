namespace PotatoManagement
{
    public class Potato
    {
        private const int MinWidth = 10;
        private const int MaxWidth = 100;
        private const int MinHeight = 50;
        private const int MaxHeight = 50;

        public Potato()
        {
        }

        public void Manage()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.IsPeeled() && !potato.IsRotten())
                {
                    this.Cook(potato);
                }
            }

            var xCoord = 50;
            var yCoord = 75;

            if (this.InRange(xCoord, yCoord))
            {
                this.VisitCell();
            }
        }

        private bool IsPeeled()
        {
            return true;
        }

        private bool IsRotten()
        {
            return false;
        }

        private void Cook(Potato potato)
        {
        }
        
        private bool InRange(int xCoord, int yCoord)
        {
            bool result = xCoord >= MinWidth && (xCoord <= MaxWidth && ((MaxHeight >= yCoord && MinHeight <= yCoord) && this.CanVisitCell()));

            return result;
        }

        private bool CanVisitCell()
        {
            return true;
        }

        private void VisitCell()
        {
        }
    }
}
