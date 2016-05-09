using System;

class CompareCharArrays
{
    static void Main()
    {
        string textA = Console.ReadLine();
        string textB = Console.ReadLine();
        int state = 0;        
        for (int i = 0; i < Math.Min(textA.Length, textB.Length); i++)
        {
            if (textA[i] > textB[i])
            {
                state = 1;
                break;
            }
            if (textA[i] < textB[i])
            {
                state = 2;
                break;
            }
        }
        if (state == 0 && textA.Length > textB.Length)
        {
            state = 1;
        }
        if (state == 0 && textB.Length > textA.Length)
        {
            state = 2;
        }
        switch (state)
        {
            case 0:
                Console.WriteLine("=");
                break;
            case 1:
                Console.WriteLine(">");
                break;
            case 2:
                Console.WriteLine("<");
                break;
            default:
                break;
        }
    }
}
