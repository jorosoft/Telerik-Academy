using System;

namespace _12.ResizableStack
{
    internal class Startup
    {
        private const int Iterations = 16;

        internal static void Main()
        {
            var stack = new MyStack<int>();

            for (int i = 0; i < Iterations; i++)
            {
                stack.Push(i);
                Console.WriteLine($"Added '{i}' to stack! --- Count: {stack.Count} --- Capacity: {stack.Capacity}");
            }

            Console.WriteLine("-------------------------------------------------------------------------------");

            for (int i = 0; i < Iterations; i++)
            {
                var poped = stack.Pop();
                Console.WriteLine($"Poped element ot stack with value: {poped} --- Stack count: {stack.Count}");
            }
            Console.WriteLine();
        }
    }
}
