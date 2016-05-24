using System;

class SymbolToNumber
{
    static void Main()
    {
        int secret = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        double result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            else if ((text[i] >= 'a' && text[i] <= 'z') || (text[i] >= 'A' && text[i] <= 'Z'))
            {
                result = text[i] * secret + 1000;
            }
            else if (text[i] >= '0' && text[i] <= '9')
            {
                result = text[i] + secret + 500;
            }
            else
            {
                result = text[i] - secret;
            }
            if (i % 2 == 0)
            {
                result /= 100;
                Console.WriteLine("{0:F2}", result);
            }
            else
            {
                result *= 100;
                Console.WriteLine(result);
            }            
        }
    }
}