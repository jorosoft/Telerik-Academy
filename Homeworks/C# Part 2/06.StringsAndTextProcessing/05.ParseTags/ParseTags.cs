using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string input = Console.ReadLine();
        var text = new StringBuilder(input.Length);
        int startPos = 0;
        int endPos = 0;
        int searchPos = 0;
        text.Append(input);
        while (true)
        {
            startPos = input.IndexOf("<upcase>", searchPos);
            if (startPos < 0)
            {
                break;
            }
            endPos = input.IndexOf("</upcase>", startPos + 8);
            searchPos = endPos + 9;
            for (int i = startPos + 8; i < endPos; i++)
            {
                text = text.Replace(text[i], char.ToUpper(text[i]), i, 1);
            }
            input = text.ToString();         
        }
        text.Replace("<upcase>", string.Empty);
        text.Replace("</upcase>", string.Empty);
        Console.WriteLine(text);
    }
}