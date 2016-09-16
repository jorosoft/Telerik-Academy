namespace Search
{
    using System;

    public class Search
    {
        private int[] elements = new int[100];

        public void SearchElement(int expectedValue)
        {
            int index = 0;

            for (index = 0; index < this.elements.Length; index++)
            {
                if (index % 10 == 0)
                {
                    if (this.elements[index] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                    }
                }

                Console.WriteLine(this.elements[index]);
            }
        }
    }
}
