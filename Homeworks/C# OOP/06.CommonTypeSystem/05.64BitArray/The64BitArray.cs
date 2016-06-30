namespace _05._64BitArray
{
    using System;

    internal class The64BitArray
    {
        internal static void Main()
        {
            var bitArray = new BitArray64(16);
            Console.WriteLine("================ TEST BITARRAY WITH NUMBER '16' ================");
            Console.WriteLine(string.Join("", bitArray));
            Console.WriteLine("The 0-th bit in binary number is: {0}", bitArray[0]);
            Console.WriteLine("The 4-th bit in binary number is: {0}", bitArray[4]);
            Console.WriteLine("========================= TEST EQUALS =========================");
            var bitArrayTwo = new BitArray64(17);
            var bitArrayCopy = new BitArray64(16);
            Console.WriteLine("Array for '16' is equal to aray of '17' ? : {0}", bitArray.Equals(bitArrayTwo));
            Console.WriteLine("Array for '16' is equal to himself ? : {0}", bitArray.Equals(bitArray));
            Console.WriteLine("Array for '16' is equal to new aray of '16' ? : {0}", bitArray.Equals(bitArrayCopy));
            Console.WriteLine("======================= TEST GETHASHCODE =======================");
            Console.WriteLine("Hashcode of array 1 : {0}", bitArray.GetHashCode());
            Console.WriteLine("Hashcode of array 1 copy : {0}", bitArrayCopy.GetHashCode());
            Console.WriteLine("Hashcode of array 2 : {0}", bitArrayTwo.GetHashCode());
            Console.WriteLine("Hashcode of array 1 again : {0}", bitArray.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("====================== TEST OPERATOR '==' ======================");
            Console.WriteLine("Array 1 == Array 2 ? : {0}", bitArray == bitArrayTwo);
            Console.WriteLine("Array 1 == Array 1 Copy ? : {0}", bitArray == bitArrayCopy);
            Console.WriteLine();
            Console.WriteLine("====================== TEST OPERATOR '!=' ======================");
            Console.WriteLine("Array 1 != Array 2 ? : {0}", bitArray != bitArrayTwo);
            Console.WriteLine("Array 1 != Array 1 Copy ? : {0}", bitArray != bitArrayCopy);
            Console.WriteLine();
        }
    }
}
