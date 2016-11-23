using System;
using System.Linq;

namespace _07.NumberOccursStatistics
{
    internal class Startup
    {
        internal static void Main()
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] sequence = new int[size];
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                sequence[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            sequence
                .Distinct()
                .OrderBy(num => num)
                .ToList()
                .ForEach(x =>
                    {
                        int currentNumberOccurs = sequence.ToList().FindAll(elem => elem == x).Count();
                        Console.WriteLine($"* '{x}' -> {currentNumberOccurs} times");
                    });

            Console.WriteLine();
        }
    }
}
