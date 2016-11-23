using System;
using System.Collections.Generic;

namespace _06.FilterNumbersOccursOddTimes
{
    internal class Startup
    {
        internal static void Main()
        {
            string input;
            List<int> sequence = new List<int>();
            HashSet<int> itemsToRemove = new HashSet<int>();
            do
            {
                input = Console.ReadLine();
                int result;
                if (int.TryParse(input, out result))
                {
                    sequence.Add(result);
                }
            } while (input != string.Empty);

            sequence
                .ForEach(item =>
                {
                    bool isElementOddTimesOccurs = sequence
                        .FindAll(x => x == item)
                        .Count % 2 != 0;

                    if (isElementOddTimesOccurs)
                    {
                        itemsToRemove.Add(item);
                    }
                });
            foreach (var item in itemsToRemove)
            {
                sequence.RemoveAll(x => x == item);
            }

            Console.WriteLine($"Filtered sequence: {string.Join(", ", sequence)}");
            Console.WriteLine();
        }
    }
}
