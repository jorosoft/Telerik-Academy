using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int openCount = 0;
        int closeCount = 0;
        bool isCorrect = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                openCount++;
            }
            if (input[i] == ')')
            {
                closeCount++;
            }
            if (closeCount > openCount)
            {
                isCorrect = false;
                break;
            }
        }
        if (openCount != closeCount)
        {
            isCorrect = false;
        }
        Console.WriteLine(isCorrect ? "Correct" : "Incorrect");
    }
}
