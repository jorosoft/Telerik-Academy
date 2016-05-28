using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        var text = Console.ReadLine();
        var result = new StringBuilder(text.Length);
        int searchIndex = 0;
        while (true)
        {
            int appendIndex = text.IndexOf("<a href=", searchIndex);
            if (appendIndex < 0)
            {
                result.Append(text.Substring(searchIndex));
                break;
            }
            result.Append(text.Substring(searchIndex, appendIndex - searchIndex));
            int linkBeginIndex = text.IndexOf("\"", appendIndex + 7);
            int linkEndIndex = text.IndexOf("\"", linkBeginIndex + 1);
            int nameBeginIndex = text.IndexOf(">", linkEndIndex + 1);
            int nameEndIndex = text.IndexOf("<", nameBeginIndex + 1);
            string link = text.Substring(linkBeginIndex + 1, linkEndIndex - linkBeginIndex - 1);
            string name = text.Substring(nameBeginIndex + 1, nameEndIndex - nameBeginIndex - 1);
            result.Append(string.Format("[{0}]({1})", name, link));
            searchIndex = nameEndIndex + 4;
        }
        Console.WriteLine(result);
    }
}