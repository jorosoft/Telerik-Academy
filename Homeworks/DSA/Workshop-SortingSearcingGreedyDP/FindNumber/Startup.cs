using System;
using System.Linq;

namespace FindNumber
{
    internal class Startup
    {
        internal static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            string[] elements = Console.ReadLine().Split(' ');
            Console.WriteLine(GetElementAt(k, elements));
        }

        public static string GetElementAt(int index, string[] elements)
        {
            int[] groups = new int[128];
            string result = string.Empty;
            for (int i = 0, len = elements.Length; i < len; i++)
            {
                if (elements[i] == string.Empty || elements[i] == null)
                {
                    groups[0]++;
                    continue;
                }

                int currentAscii = (int)elements[i][0];
                groups[currentAscii]++;
            }

            int sumElements = 0;
            int targetGroup = 0;
            for (int i = 0, len = groups.Length; i < len; i++)
            {
                sumElements += groups[i];
                if (sumElements > index)
                {
                    targetGroup = i;
                    break;
                }
            }

            char targetSymbol = (char)targetGroup;
            string[] filteredArray;
            filteredArray = elements.Where(x => x[0] == targetSymbol).OrderBy(x => x).ToArray();
            int newIndex = index - (sumElements - groups[targetGroup]);
            result = filteredArray[newIndex];

            return result;
        }
    }
}