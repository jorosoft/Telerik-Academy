using System;
using System.Linq;

namespace _08.FindArrayMajorant
{
    internal class Startup
    {
        internal static void Main()
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            int[] sequence = new int[size];
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                sequence[i] = int.Parse(Console.ReadLine());
            }

            int? majorant = GetArrayMajorant(sequence);
            Console.WriteLine();
            if (majorant == null)
            {
                Console.WriteLine("Array haven't majorant!");
            }
            else
            {
                Console.WriteLine($"Array majorant is: {majorant}");
            }

            Console.WriteLine();
        }

        public static int? GetArrayMajorant(int[] array)
        {
            int minCount = array.Length / 2 + 1;
            int? result = null;
            array
                .Distinct()
                .ToList()
                .ForEach(x =>
                {
                    int currentNumberOccurs = array.ToList().FindAll(elem => elem == x).Count();
                    if (currentNumberOccurs >= minCount)
                    {
                        result = x;
                    }
                });

            return result;
        }
    }
}
