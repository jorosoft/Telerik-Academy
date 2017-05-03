namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            bool result = false;

            for (int i = 0; i < this.items.Count; i++)
            {
                if (this.items[i].CompareTo(item) == 0)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool BinarySearch(T item)
        {
            return BiSearch(item, 0, this.items.Count - 1);
        }


        private bool BiSearch(T item, int startIndex, int endIndex)
        {
            if (startIndex <= endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;
                if (this.items[middleIndex].CompareTo(item) == 0)
                {
                    return true;
                }
                else if (this.items[middleIndex].CompareTo(item) < 0)
                {
                    return BiSearch(item, middleIndex + 1, endIndex);
                }
                else
                {
                    return BiSearch(item, startIndex, middleIndex - 1);
                }
            }

            return false;
        }

        public void Shuffle()
        {
            for (int i = 0; i < this.items.Count - 1; i++)
            {
                var rand = new Random();
                var newIndex = rand.Next(i, this.items.Count);
                T buffer = this.items[i];
                this.items[i] = this.items[newIndex];
                this.items[newIndex] = buffer;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
