using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 97);
        }
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (input[i] == alphabet[j])
                {
                    Console.WriteLine(j);
                    break; 
                }
            }
        }
    }
}