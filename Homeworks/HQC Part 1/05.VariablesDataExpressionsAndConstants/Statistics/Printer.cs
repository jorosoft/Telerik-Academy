namespace Statistics
{
    using System;

    public class Printer
    {
        public void PrintStatistics(double[] data)
        {
            if (data == null)
            {
                Console.WriteLine("Incorrect data!");
                return;
            }

            double maxValue = 0;
            for (int i = 0, count = data.Length; i < count; i++)
            {
                if (data[i] > maxValue)
                {
                    maxValue = data[i];
                }
            }

            this.PrintMaximalValue(maxValue);

            double minValue = 0;
            for (int i = 0, count = data.Length; i < count; i++)
            {
                if (data[i] < minValue)
                {
                    minValue = data[i];
                }
            }

            this.PrintMinimalValue(minValue);

            double sumOfElements = 0;
            for (int i = 0, count = data.Length; i < count; i++)
            {
                sumOfElements += data[i];
            }

            double averageValue = sumOfElements / data.Length;
            this.PrintAverageValue(averageValue);
        }

        private void PrintAverageValue(double averageValue)
        {
            Console.WriteLine($"Average value is: {averageValue}");
        }

        private void PrintMinimalValue(double minValue)
        {
            Console.WriteLine($"Minimal value is: {minValue}");
        }

        private void PrintMaximalValue(double maxValue)
        {
            Console.WriteLine($"Maximal value is: {maxValue}");
        }
    }
}
