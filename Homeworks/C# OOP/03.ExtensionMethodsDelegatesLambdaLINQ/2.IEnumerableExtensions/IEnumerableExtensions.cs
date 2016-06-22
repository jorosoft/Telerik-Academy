namespace _2.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    internal static class IEnumerableExtensions
    {
        internal static void Main()
        {
            IEnumerable<int> numbers = new[] { 3, 2, 1, 4 };

            IEnumerable<double> doubleNumbers = new[] { 9.99, 3.14, 5.01, 17.28 };

            Console.WriteLine("============ STARTUP DATA ============");
            Console.Write("INTEGER DATA => ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("DOUBLE DATA => ");
            foreach (var item in doubleNumbers)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("============ SUM ============");
            Console.WriteLine(numbers.Sum<int>());
            Console.WriteLine(doubleNumbers.Sum<double>());
            Console.WriteLine("============ PRODUCT ============");
            Console.WriteLine(numbers.Product<int>());
            Console.WriteLine(doubleNumbers.Product<double>());
            Console.WriteLine("============ MIN ============");
            Console.WriteLine(numbers.Min<int>());
            Console.WriteLine(doubleNumbers.Min<double>());
            Console.WriteLine("============ MAX ============");
            Console.WriteLine(numbers.Max<int>());
            Console.WriteLine(doubleNumbers.Max<double>());
            Console.WriteLine("============ AVERAGE ============");
            Console.WriteLine(numbers.Avg<int>());
            Console.WriteLine(doubleNumbers.Avg<double>());
            Console.WriteLine();
        }
    }
}
