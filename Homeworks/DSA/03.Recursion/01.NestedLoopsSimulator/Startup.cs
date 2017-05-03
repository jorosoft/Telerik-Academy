using System;

namespace _01.NestedLoopsSimulator
{
    internal class Startup
    {
        internal static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            Recursion(n, 0, number);
        }

        private static void Recursion(int n, int index, int[] num)
        {
            if (index == n)
            {
                PrintNumber(num);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    num[index] = i + 1;
                    Recursion(n, index + 1, num);
                }
            }
        }

        private static void PrintNumber(int[] number)
        {
            foreach (var digit in number)
            {
                Console.Write("{0} ", digit);
            }

            Console.WriteLine();
        }
    }
}
