using System;

class TextToNumber
{
    static void Main()
    {
        int numberM = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        long result = 0;
        text = text.ToUpper();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if (text[i] > 47 && text[i] < 58)
            {
                result *= Convert.ToInt32(text[i].ToString());
            }
            else if (text[i] > 64 && text[i] < 91)
            {
                result += (text[i] - 65);
            }
            else
            {
                result %= numberM;
            }
        }
        Console.WriteLine(result);
    }
}