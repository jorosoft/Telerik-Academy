using System;

namespace Passwords
{
    internal class Startup
    {
        internal static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string result = GetPassword(n, k, order);
            Console.WriteLine(result);
        }

        public static string GetPassword(int passLength, int kPass, string order)
        {
            string result = string.Empty;
            // magic

            return result;
        }
    }
}
