using System;
using System.Collections.Generic;

namespace _09.TopFiftySequenceMembers
{
    internal class Startup
    {
        internal static void Main()
        {
            int n = 2;
            int iterations = 50;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            for (int i = 0; i < iterations; i++)
            {
                int num = queue.Dequeue();
                Console.Write($"{num}, ");
                queue.Enqueue(num + 1);
                queue.Enqueue(2 * num + 1);
                queue.Enqueue(num + 2);
            }

            Console.WriteLine();
        }
    }
}
