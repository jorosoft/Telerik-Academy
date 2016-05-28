using System;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string[] text = Console.ReadLine().Split('.');
        List<string> result = new List<string>(text.Length);
        for (int sentence = 0; sentence < text.Length; sentence++)
        {
            int searchPosition = 0;
            while (true)
            {
                int position = text[sentence].IndexOf(word, searchPosition);
                if (position >= 0)
                {
                    if (position == 0 && text[sentence].Length == word.Length)
                    {
                        result.Add(text[sentence].Trim());
                        break;
                    }
                    if (position == 0 && !char.IsLetter(text[sentence][word.Length]))
                    {
                        result.Add(text[sentence].Trim());
                        break;
                    }
                    if (position == text[sentence].Length - word.Length && !char.IsLetter(text[sentence][position - 1]))
                    {
                        result.Add(text[sentence].Trim());
                        break;
                    }
                    if (!char.IsLetter(text[sentence][position - 1]) && !char.IsLetter(text[sentence][position + word.Length]))
                    {
                        result.Add(text[sentence].Trim());
                        break;
                    }
                    searchPosition = position + word.Length;
                }
                else
                {
                    break;
                }
            }
        }
        if (result.Count > 0)
        {
            Console.WriteLine(string.Join(". ", result) + ".");
        }
        else
        {
            Console.WriteLine();
        }
    }
}