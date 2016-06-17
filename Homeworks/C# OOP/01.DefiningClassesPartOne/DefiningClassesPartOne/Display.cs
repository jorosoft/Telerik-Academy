namespace DefiningClassesPartOne
{
    using System;

    public class Display
    {
        private string size;
        private int numberOfColors;

        public Display(string size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public string Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("Display size description must be large than one symbol!");
                }

                this.size = value.Trim();
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                if (value < 1 || value > int.MaxValue)
                {
                    throw new ArgumentException("Incorrect number of colors!");
                }

                this.numberOfColors = value;
            }
        }
    }
}
