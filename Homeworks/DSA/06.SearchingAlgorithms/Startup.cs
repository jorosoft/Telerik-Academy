using System;

namespace SortingHomework
{
    internal class Startup
    {
        internal static void Main()
        {
            var collection = new SortableCollection<int>(new[] { 0, 11, 22, 33, 101, 101 });
            Console.WriteLine("All items in collection:");
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            Console.WriteLine("Linear search for value '3' result:");
            var result = collection.LinearSearch(3);
            Console.WriteLine(result ? " * Searched element persist in collection!" : " !!!ERROR: Searched element is not found!");
            Console.WriteLine("Linear search for value '101' result:");
            result = collection.LinearSearch(101);
            Console.WriteLine(result ? " * Searched element persist in collection!" : " !!!ERROR: Searched element is not found!");
            Console.WriteLine();

            Console.WriteLine("Binary search for value '33' result:");
            result = collection.BinarySearch(33);
            Console.WriteLine(result ? " * Searched element persist in collection!" : " !!!ERROR: Searched element is not found!");
            Console.WriteLine("Binary search for value '333' result:");
            result = collection.BinarySearch(333);
            Console.WriteLine(result ? " * Searched element persist in collection!" : " !!!ERROR: Searched element is not found!");
            Console.WriteLine();

            Console.WriteLine("All items after shuffle in collection:");
            collection.Shuffle();            
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();
            Console.WriteLine("All items after another shuffle in collection:");
            collection.Shuffle();
            collection.PrintAllItemsOnConsole();
            Console.WriteLine();
        }
    }
}
