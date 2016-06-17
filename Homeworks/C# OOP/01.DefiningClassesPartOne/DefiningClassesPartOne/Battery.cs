namespace DefiningClassesPartOne
{
    using System;

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
            : this(model, hoursIdle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("The model's name must be large than one symbol!");
                }

                this.model = value.Trim();
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value < 1 || value > int.MaxValue)
                {
                    throw new ArgumentException("Incorrect number for hours idle!");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value < 1 || value > int.MaxValue)
                {
                    throw new ArgumentException("Incorrect number for hours talk!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType { get; set; }
    }
}
