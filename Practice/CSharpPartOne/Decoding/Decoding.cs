using System;

class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        int result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if ((text[i] >= 65 && text[i] <= 90) || (text[i] >= 97 && text[i] <= 122))
            {
                result = text[i] * salt + 1000;
            }
            else if (text[i] >= 48 && text[i] <= 57)
            {
                result = text[i] + salt + 500;
            }
            else
            {
                result = text[i] - salt;
            }
            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F2}", result / 100.00);
            }
            else
            {
                Console.WriteLine("{0}", result * 100);
            }
        }
    }
}
