namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class Searching
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            bool hasArray = arr != null && arr.Length > 0;
            Debug.Assert(hasArray, "Array is empty or undefined!");
            bool isArraySorted = IsSorted(arr);
            Debug.Assert(isArraySorted, "Array must be sorted to use BinarySearch!");
               
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            bool isStartIndexValid = startIndex >= 0 && startIndex < arr.Length;
            bool isEndIndexValid = endIndex >= 0 && endIndex < arr.Length;
            Debug.Assert(isStartIndexValid, "Start index must be positive and smaller than array length!");
            Debug.Assert(isEndIndexValid, "End index must be positive and smaller than array length!");
            Debug.Assert(startIndex < endIndex, "Start index must be smaller than end index!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    bool minIndexIsValid = midIndex >= 0 && midIndex < arr.Length;
                    Debug.Assert(minIndexIsValid, "Invalid index of found minimal element!");

                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        private static bool IsSorted<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index + 1].CompareTo(arr[index]) == -1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
