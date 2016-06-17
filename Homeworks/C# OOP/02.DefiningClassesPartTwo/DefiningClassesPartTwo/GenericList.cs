namespace DefiningClassesPartTwo
{
    using System;

    public class GenericList<T> where T : IComparable<T>
    {
        private T[] list;
        private int currentIndex;

        public GenericList()
        {
            this.currentIndex = 0;
            this.list = new T[4];
        }

        public GenericList(int capacity)
        {
            this.currentIndex = 0;
            this.list = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.currentIndex;
            }
        }

        public int Capacity
        {
            get
            {
                return this.list.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
            }

            set
            {
                if (index < 0 || index >= this.list.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                this.list[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.currentIndex >= this.list.Length)
            {
                this.ResizeList(this.list.Length);
            }

            this.list[this.currentIndex] = element;
            this.currentIndex++;
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < this.currentIndex; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.currentIndex--;
        }

        public void Insert(int index, T element)
        {
            if (index < 0 || index >= this.currentIndex)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.currentIndex >= this.list.Length)
            {
                this.ResizeList(this.list.Length);
            }

            for (int i = this.currentIndex; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = element;
            this.currentIndex++;
        }

        public void Clear()
        {
            Array.Clear(this.list, 0, this.list.Length);
            this.currentIndex = 0;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (this.list[i].ToString() == element.ToString())
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < this.currentIndex; i++)
            {
                if (i != this.currentIndex - 1)
                {
                    result += this.list[i].ToString() + ", ";
                }
                else
                {
                    result += this.list[i].ToString();
                }
            }

            return result;
        }

        public T Min()
        {
            T minValue = this.list[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.list[i].CompareTo(minValue) < 0)
                {
                    minValue = this.list[i];
                }
            }

            return minValue;
        }

        public T Max()
        {
            T maxValue = this.list[0];
            for (int i = 1; i < this.currentIndex; i++)
            {
                if (this.list[i].CompareTo(maxValue) > 0)
                {
                    maxValue = this.list[i];
                }
            }

            return maxValue;
        }

        private void ResizeList(int currentLength)
        {
            var newList = new T[currentLength * 2];
            for (int i = 0; i < currentLength; i++)
            {
                newList[i] = this.list[i];
            }

            this.list = newList;
        }
    }
}
