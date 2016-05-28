using System;

class SubStringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();
        int count = 0;
        int startIndex = 0;
        int foundIndex = 0;
        while (true)
        {
            foundIndex = text.IndexOf(pattern, startIndex);
            if (foundIndex < 0)
            {
                break;
            }
            count++;
            startIndex = foundIndex + 1;
        }
        Console.WriteLine(count);
    }
}