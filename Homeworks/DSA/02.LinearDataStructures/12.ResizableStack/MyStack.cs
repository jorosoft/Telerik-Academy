namespace _12.ResizableStack
{
    public class MyStack<T>
    {
        private T[] data;

        public MyStack()
        {
            this.data = new T[4];
        }

        public int Count { get; private set; }

        public int Capacity
        {
            get
            {
                return this.data.Length;
            }
        }

        public void Push(T value)
        {
            if (this.Count == this.data.Length && this.Count > 0)
            {
                var newArray = new T[this.Count * 2];
                this.data.CopyTo(newArray, 0);
                this.data = newArray;
            }

            data[this.Count] = value;
            this.Count++;
        }

        public T Pop()
        {
            T result = this.data[this.Count - 1];
            this.Count--;

            return result;
        }
    }
}
