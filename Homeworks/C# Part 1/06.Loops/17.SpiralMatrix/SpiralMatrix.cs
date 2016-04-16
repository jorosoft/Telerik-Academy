using System;

class SpiralMatrix
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int[,] matrix = new int[numberN, numberN];
        int counter = 1;
        int indexer = 0;
        while (counter <= (numberN * numberN))
        {
            for (int positiveX = indexer; positiveX < numberN - indexer; positiveX++)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[indexer, positiveX] = counter;
                    counter++;
                }                
            }
            for (int negativeY = indexer + 1; negativeY < numberN - indexer; negativeY++)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[negativeY, numberN - indexer - 1] = counter;
                    counter++;
                }                
            }
            for (int negativeX = numberN - indexer - 2; negativeX >= indexer; negativeX--)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[numberN -indexer - 1, negativeX] = counter;
                    counter++;
                }                
            }
            for (int positiveY = numberN - indexer - 2; positiveY > indexer; positiveY--)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[positiveY, indexer] = counter;
                    counter++;
                }                
            }
            indexer++;
        }
        for (int row = 0; row < numberN; row++)
        {
            for (int column = 0; column < numberN; column++)
            {
                Console.Write("{0} ", matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}
