namespace _05._64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class BitArray64 : IEnumerable<int>
    {
        private int[] array;

        public BitArray64(long number)
        {
            if (number < long.MinValue || number > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException("Number is not Int64 type!");
            }

            this.array = BuildBitArray(number);
        }

        public int this[int index]
        {
            get
            {
                return this.array[array.Length - 1 - index];
            }

            set
            {
                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("Invalid value for bit!");
                }

                this.array[array.Length - 1 - index] = value;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int bit in this.array)
            {
                yield return bit;
            }
        }

        private int[] BuildBitArray(long number)
        {
            var bitArray = new int[64];
            bitArray = Convert.ToString(number, 2).PadLeft(64, '0')
                        .ToCharArray().Select(x => x - '0').ToArray();  

            return bitArray;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var compared = obj as BitArray64;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[array.Length -1 - i] != compared[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 7 + this.array.GetHashCode();
            hash += base.GetHashCode();
            return hash;
        }

        public static bool operator ==(BitArray64 firstArr, BitArray64 secondArr)
        {
            if (firstArr.Equals(secondArr))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(BitArray64 firstArr, BitArray64 secondArr)
        {
            if (firstArr == secondArr)
            {
                return false;
            }

            return true;
        }
    }
}
