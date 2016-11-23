using System;
using System.Collections.Generic;

namespace _04.LongestSubsequence
{
    public class Startup
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

            Console.WriteLine($"Longest subsequence: {string.Join(", ", GetLongestSubsequence(sequence))}");
            Console.WriteLine();           
        }

        public static IList<int> GetLongestSubsequence(IList<int> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException();
            }

            if (sequence.Count == 0)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();
            int currentSubsequenceCount = 1;
            int maxSubsequenceCount = 1;
            int currentNumber = sequence[0];
            int searchedNumber = sequence[0];
            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == currentNumber)
                {
                    currentSubsequenceCount++;
                }
                else
                {
                    currentSubsequenceCount = 1;
                    currentNumber = sequence[i];
                }

                if (currentSubsequenceCount > maxSubsequenceCount)
                {
                    maxSubsequenceCount = currentSubsequenceCount;
                    searchedNumber = currentNumber;
                }
            }

            for (int i = 0; i < maxSubsequenceCount; i++)
            {
                result.Add(searchedNumber);
            }

            return result;
        }
    }
}
