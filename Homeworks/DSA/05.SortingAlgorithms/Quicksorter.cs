namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private static void QuickSort(IList<T> collection, int startIndex, int endIndex)
        {
            int pivot = collection.Count / 2;

            if (startIndex < endIndex)
            {
                pivot = Partition(collection, startIndex, endIndex);
                QuickSort(collection, startIndex, pivot - 1);
                QuickSort(collection, pivot + 1, endIndex);
            }
        }

        private static int Partition(IList<T> collection, int startIndex, int endIndex)
        {
            T pivot = collection[endIndex];
            int i = startIndex - 1;

            for (int j = startIndex; j < endIndex; j++)
            {
                if (collection[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(collection, i, j);
                }
            }

            Swap(collection, i + 1, endIndex);

            return i + 1;
        }

        private static void Swap(IList<T> collection, int firstIndex, int secondIndex)
        {
            T buffer;
            buffer = collection[firstIndex];
            collection[firstIndex] = collection[secondIndex];
            collection[secondIndex] = buffer;
        }
    }
}
