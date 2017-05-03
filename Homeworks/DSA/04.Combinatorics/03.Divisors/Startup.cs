using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Divisors
{
    internal class Startup
    {
        private static int[] sequence;
        private static List<int> set = new List<int>();
        private static List<int> isAvailable = new List<int>();
        private static List<int> numbers = new List<int>();
        private static List<int> divisorsCount = new List<int>();
        private static List<int> equalDivisors = new List<int>();

        internal static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            sequence = new int[n];
            for (int i = 0; i < n; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
                isAvailable.Add(1);
            }

            GenerateNumbers(n);
            for (int i = 0; i < numbers.Count; i++)
            {
                divisorsCount.Add(GetCountOfDivisors(numbers[i]));
            }

            int minDivisorsCount = divisorsCount.Min();
            int countEqualMinDivisors = divisorsCount.Where(x => x == minDivisorsCount).Count();
            int index = 0;
            if (countEqualMinDivisors > 1)
            {
                for (int i = 0; i < divisorsCount.Count; i++)
                {
                    if (divisorsCount[i] == minDivisorsCount)
                    {
                        equalDivisors.Add(numbers[i]);
                    }
                }

                Console.WriteLine(equalDivisors.Min());
            }
            else
            {
                index = divisorsCount.IndexOf(minDivisorsCount);
                Console.WriteLine(numbers[index]);
            }



        }

        private static void GenerateNumbers(int n)
        {
            if (set.Count == n)
            {
                numbers.Add(int.Parse(string.Join("", set)));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (isAvailable[i] == 0)
                {
                    continue;
                }

                set.Add(sequence[i]);
                isAvailable[i]--;
                GenerateNumbers(n);
                isAvailable[i]++;
                set.RemoveAt(set.Count - 1);
            }
        }

        private static int GetCountOfDivisors(int n)
        {
            int result = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}