using System;

namespace _05.NKSubsets
{
    internal class Startup
    {
        private static string[] subSet;
        private static string[] set;
        private const int n = 3;

        internal static void Main()
        {
            int k = 2;
            subSet = new string[k];
            set = new string[n] { "hi", "a", "b" };

            Combination(0);
        }

        private static void Combination(int index)
        {
            if (index == subSet.Length)
            {
                Console.WriteLine($"({string.Join(" ", subSet)})");
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                subSet[index] = set[i];
                Combination(index + 1);
            }
        }
    }
}
