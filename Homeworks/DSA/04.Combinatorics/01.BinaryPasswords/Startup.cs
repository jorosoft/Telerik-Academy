using System;

namespace _01.BinaryPasswords
{
    internal class Startup
    {
        internal static void Main()
        {
            string input = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    counter++;
                }
            }

            long result = (long)Math.Pow(2, counter);
            Console.WriteLine(result);
        }
    }
}
