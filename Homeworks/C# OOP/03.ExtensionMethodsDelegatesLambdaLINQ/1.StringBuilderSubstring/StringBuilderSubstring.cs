namespace _1.StringBuilderSubstring
{
    using System;
    using System.Text;

    internal static class StringBuilderSubstring
    {
        internal static void Main()
        {
            var myString = new StringBuilder();
            myString.Append("Custom text to test this functionallity...");
            Console.WriteLine("============= OTIGINAL STRING =============");
            Console.WriteLine();
            Console.WriteLine(myString.ToString());
            Console.WriteLine();            
            Console.WriteLine("========= TEST RETURNED SUBSTRING =========");
            Console.WriteLine();
            Console.WriteLine(myString.Substring(7, 12));
            Console.WriteLine();
            Console.WriteLine("===========================================");
        }
    }
}
