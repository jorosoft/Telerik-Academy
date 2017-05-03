using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Permutations
{
    internal class Startup
    {
        internal static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Permutations(n, new List<int>());
        }

        public static void Permutations(int n, IList<int> set)
        {
            if (set.Count == n)
            {
                PrintSet(set);
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (set.Contains(i))
                {
                    continue;
                }

                set.Add(i);
                Permutations(n, set);
                set.RemoveAt(set.Count - 1);
            }
        }

        private static void PrintSet(IList<int> set)
        {
            Console.WriteLine($"{{{string.Join(" ", set)}}}");
        }
    }
}
