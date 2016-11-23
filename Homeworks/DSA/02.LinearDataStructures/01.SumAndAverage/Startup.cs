using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAndAverage
{
    internal class Startup
    {
        internal static void Main()
        {
            string input;
            List<int> sequence = new List<int>();
            do
            {
                input = Console.ReadLine();
                int result;
                if (int.TryParse(input, out result))
                {
                    sequence.Add(result);
                }
            } while (input != string.Empty);

            int sum = sequence.Sum();
            double average = sequence.Average();

            Console.WriteLine($"The sum of sequence is: {sum}");
            Console.WriteLine($"The average of sequence is: {average}");
            Console.WriteLine();
        }
    }
}
