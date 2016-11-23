using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortingSequence
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

            sequence.Sort();
            Console.WriteLine($"Sorted sequence: {string.Join(", ", sequence)}");
        }
    }
}
