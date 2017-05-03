using System;

namespace _06.StringsSubset
{
    internal class Startup
    {
        private static string[] subset;
        private static string[] set;

        internal static void Main()
        {
            subset = new string[2];
            set = new string[3] { "test", "rock", "fun" };

            Combination(0, 0);
        }

        private static void Combination(int index, int start)
        {
            if (index == subset.Length)
            {
                Console.WriteLine($"({string.Join(" ", subset)})");
                return;
            }
            for (int i = start; i < set.Length; i++)
            {
                subset[index] = set[i];
                Combination(index + 1, i + 1);
            }
        }
    }
}
