using System;

class Cube
{
    static void PrintMatrix(char[,] resultPattern, int dimm)
    {
        for (int i = 0; i < dimm; i++)
        {
            for (int j = 0; j < dimm; j++)
            {
                Console.Write(resultPattern[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        char[,] pattern = new char[2 * number - 1, 2 * number - 1];
        for (int i = 0; i < 2 * number - 1; i++)
        {
            for (int j = 0; j < 2 * number - 1; j++)
            {
                pattern[i, j] = ' ';
            }
        }
        for (int i = 0, index = 0; i < number; i++, index++)
        {
            for (int j = number - 1 - index; j < 2 * number - 1; j++)
            {
                if (i > 1 && j >= 2 * number - 1 - index && j <= 2 * number - 3)
                {
                    pattern[i, j] = 'X';
                }
                else
                {
                    pattern[i, j] = ':';
                }

            }
        }
        for (int i = number, index = 1; i < 2 * number - 1; i++, index++)
        {
            for (int j = 0; j < 2 * number - index - 1; j++)
            {
                if (i >= number && i <= 2 * number - 3 && j > 0 && j < number - 1)
                {
                    continue;
                }
                if (i < 2 * number - 3 && j >= number && j <= 2 * number - 3 - index)
                {
                    pattern[i, j] = 'X';
                }
                else
                {
                    pattern[i, j] = ':';
                }
            }
        }
        for (int i = 1, index = 0; i < number - 1; i++, index++)
        {
            for (int j = number - 1; j <= 2 * number - 4; j++)
            {
                pattern[i, j - index] = '/';
            }
        }
        PrintMatrix(pattern, 2 * number - 1);
    }
}