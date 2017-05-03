using System;

namespace OddNumber
{
    internal class Startup
    {
        internal static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long result = 0;
            for (int i = 0; i < n; i++)
            {
                var input = long.Parse(Console.ReadLine());
                result ^= input;
            }
            
            Console.WriteLine(result);
        }
    }
}