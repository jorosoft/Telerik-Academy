using System;

namespace _03.CombinationsWithoutDuplicates
{
    internal class Startup
    {
        internal static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            int[] number = new int[k];
            Recursion(n, k, 0, 0, number);
        }

        private static void Recursion(int n, int k, int index, int start, int[] num)
        {
            if (index == k)
            {
                PrintNumber(num);
            }
            else
            {
                for (int i = start; i < n; i++)
                {
                    num[index] = i + 1;
                    Recursion(n, k, index + 1, i + 1, num);
                }
            }
        }

        private static void PrintNumber(int[] number)
        {
            Console.WriteLine($"({string.Join(" ", number)})");
        }
    }
}
