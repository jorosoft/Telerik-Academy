namespace Assertions_Homework
{
    using System;

    internal class AssertionsHomework
    {
        internal static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));

            // Test searching in unsorted array
            //// Searching.BinarySearch(arr, 15);

            Sorting.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty and undefined array
            //// Sorting.SelectionSort<int>(null);
            //// Sorting.SelectionSort(new int[0]);

            // Test searching in empty and undefined array 
            //// Searching.BinarySearch(null, 1000);
            //// Searching.BinarySearch(new int[0], 1000);

            // Test sorting single element array
            //// Sorting.SelectionSort(new int[1]);

            Console.WriteLine(Searching.BinarySearch(arr, -1000));
            Console.WriteLine(Searching.BinarySearch(arr, 0));
            Console.WriteLine(Searching.BinarySearch(arr, 17));
            Console.WriteLine(Searching.BinarySearch(arr, 10));
            Console.WriteLine(Searching.BinarySearch(arr, 1000));
        }
    }
}