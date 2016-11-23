using System;
using System.Collections.Generic;

namespace _02.ReverseIntegers
{
    internal class Startup
    {
        internal static void Main()
        {
            string input;
            Stack<int> stack = new Stack<int>();
            do
            {
                input = Console.ReadLine();
                int result;
                if (int.TryParse(input, out result))
                {
                    stack.Push(result);
                }
            } while (input != string.Empty);

            Console.Write("Reversed sequence: ");
            for (int i = 0, len = stack.Count; i < len; i++)
            {
                Console.Write($"{stack.Pop()}, ");
            }

            Console.WriteLine();
        }
    }
}
