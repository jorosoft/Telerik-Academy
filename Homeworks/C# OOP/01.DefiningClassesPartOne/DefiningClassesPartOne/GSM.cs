namespace DefiningClassesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        private const decimal CallPricePerMinute = 0.37m;
        private static GSM iphone4s;
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;

        static GSM()
        {
            IPhone4S = new GSM("IPhone4S", "Apple", 420.85m, "Kiro Kirov", new Battery("AH-11", 500, 220, BatteryType.LiPo), new Display("640x960", 64000));
        }

        public GSM(string model, string manifacturer)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
        }

        public GSM(string model, string manifacturer, decimal price)
            : this(model, manifacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manifacturer, decimal price, string owner)
            : this(model, manifacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manifacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manifacturer, price, owner)
        {
            this.Battery = battery;
            this.Dispay = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iphone4s;
            }

            set
            {
                iphone4s = value;
            }
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
                    throw new ArgumentException("The length of the model must be large than one symbol!");
                }

                this.model = value.Trim();
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("The length of the manifacturer must be large than one symbol!");
                }

                this.manifacturer = value.Trim();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can't be negative number!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value.Trim().Length < 1)
                {
                    throw new ArgumentException("The owner's name must be large than one symbol!");
                }

                this.owner = value.Trim();
            }
        }

        public Battery Battery { get; set; }

        public Display Dispay { get; set; }

        public List<Call> CallHistory { get; set; } = new List<Call>();

        public override string ToString()
        {
            string result = this.manifacturer + "|" + this.Model + "|" + this.Price + "|";
            if (this.Owner == null)
            {
                result += $"{string.Empty}|";
            }
            else
            {
                result += $"{this.Owner}|";
            }

            if (this.Battery == null)
            {
                result += $"{string.Empty}|{string.Empty}|{string.Empty}|{string.Empty}|";
            }
            else
            {
                result += $"{this.Battery.Model}|{this.Battery.HoursIdle}|{this.Battery.HoursTalk}|{this.Battery.BatteryType}|";
            }

            if (this.Dispay == null)
            {
                result += $"{string.Empty}|{string.Empty}";
            }
            else
            {
                result += $"{this.Dispay.Size}|{this.Dispay.NumberOfColors}";
            }

            return result;
        }

        public string[] GetPhoneInfo(string phoneInfo)
        {
            return phoneInfo.Split('|');
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public decimal CalculateTotalCallsCost()
        {
            decimal result = 0m;
            decimal currentCallCost = 0m;
            foreach (var call in this.CallHistory)
            {
                currentCallCost = call.Duration * CallPricePerMinute;
                result += currentCallCost;
            }

            return result;
        }

        public void RemoveLongestCall()
        {
            int maxCallDuration = 0;
            foreach (var call in this.CallHistory)
            {
                if (call.Duration > maxCallDuration)
                {
                    maxCallDuration = call.Duration;
                }
            }

            this.CallHistory.RemoveAll(x => x.Duration == maxCallDuration);
        }
    }
}
