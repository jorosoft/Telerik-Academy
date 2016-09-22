namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class Sorting
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            bool hasArray = arr != null;
            Debug.Assert(hasArray, "Array is undefined!");
            Debug.Assert(arr.Length > 1, "Array must have at least 2 elements to be sorted!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }       

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
       where T : IComparable<T>
        {
            bool isStartIndexValid = startIndex >= 0 && startIndex < arr.Length;
            bool isEndIndexValid = endIndex >= 0 && endIndex < arr.Length;
            Debug.Assert(isStartIndexValid, "Start index must be positive and smaller than array length!");
            Debug.Assert(isEndIndexValid, "End index must be positive and smaller than array length!");
            Debug.Assert(startIndex < endIndex, "Start index must be smaller than end index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            bool minElementIndexIsValid = minElementIndex >= 0 && minElementIndex < arr.Length;
            Debug.Assert(minElementIndexIsValid, "Invalid index of found minimal element!");

            return minElementIndex;
        }
    }
}
