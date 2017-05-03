using System;

namespace ExchangeRates
{
    internal class Startup
    {
        internal static void Main()
        {
            decimal ammount = decimal.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            decimal[] firstRate = new decimal[days];
            decimal[] secondRate = new decimal[days];
            for (int i = 0; i < days; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                firstRate[i] = decimal.Parse(input[0]);
                secondRate[i] = decimal.Parse(input[1]);
            }

            decimal result = GetValueWithBestProfit(ammount, firstRate, secondRate);
            Console.WriteLine("{0:F2}", result);
        }

        public static decimal GetValueWithBestProfit(decimal ammount, decimal[] firstRate, decimal[] secondRate)
        {
            int days = firstRate.Length;
            decimal result = ammount;
            decimal currentSecondValue = ammount * firstRate[0];            

            for (int i = 1; i < days; i++)
            {
                var currentFirst = currentSecondValue * secondRate[i];
                var currentSecond = result * firstRate[i];

                if (result < currentFirst)
                {
                    result = currentFirst;
                }

                if (currentSecondValue < currentSecond)
                {
                    currentSecondValue = currentSecond;
                }
            }

            return result;
        }
    }
}