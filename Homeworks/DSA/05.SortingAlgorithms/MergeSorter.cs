namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            MergeSort(collection, 0, collection.Count - 1);
        }

        private static void MergeSort(IList<T> collection, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(collection, left, mid);
                MergeSort(collection, (mid + 1), right);

                Merge(collection, left, (mid + 1), right);
            }
        }

        static public void Merge(IList<T> collection, int left, int mid, int right)
        {
            T[] temp = new T[collection.Count];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (collection[left].CompareTo(collection[mid]) <= 0)
                    temp[tmp_pos++] = collection[left++];
                else
                    temp[tmp_pos++] = collection[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = collection[left++];

            while (mid <= right)
                temp[tmp_pos++] = collection[mid++];

            for (i = 0; i < num_elements; i++)
            {
                collection[right] = temp[right];
                right--;
            }
        }
    }
}
