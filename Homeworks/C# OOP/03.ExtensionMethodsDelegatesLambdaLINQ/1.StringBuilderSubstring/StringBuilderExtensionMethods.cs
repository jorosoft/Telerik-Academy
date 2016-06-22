namespace _1.StringBuilderSubstring
{
    using System.Text;

    public static class StringBuilderExtensionMethods
    {
        public static string Substring(this StringBuilder text, int index, int length)
        {
            return text.ToString().Substring(index, length);
        }
    }
}
