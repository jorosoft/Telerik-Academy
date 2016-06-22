namespace _17.LongestString
{
    using System;
    using System.Linq;

    internal class LongestString
    {
        internal static void Main()
        {
            var text = new[] { "This", "is", "a", "test", "for", "searching", "the", "longest", "string" };
            var result =
                (from t in text
                 orderby t.Length descending
                 select t).FirstOrDefault();
            Console.WriteLine("========= LONGEST STRING IN SEQUENCE =========");
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
