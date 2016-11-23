using System;
using System.Collections.Generic;

namespace _05.NegativeNumbersRemover
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

            for (int i = sequence.Count - 1; i >= 0 ; i--)
            {
                if (sequence[i] < 0)
                {
                    sequence.Remove(sequence[i]);
                }
            }

            Console.WriteLine($"Filtered sequence: {string.Join(", ", sequence)}");
        }
    }
}
