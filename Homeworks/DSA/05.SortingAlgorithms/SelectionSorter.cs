namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null || collection.Count < 2)
            {
                return;
            }
                        
            for (int i = 0, len = collection.Count; i < len; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (collection[j].CompareTo(collection[minIndex]) < 0)
                    {
                        minIndex = j;
                    }                    
                }

                Swap(collection, i, minIndex);
            }
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
