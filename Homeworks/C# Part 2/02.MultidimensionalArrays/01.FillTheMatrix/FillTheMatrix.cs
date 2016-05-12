using System;

class FillTheMatrix
{
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column == matrix.GetLength(1) - 1)
                {
                    Console.Write("{0}", matrix[row, column]);
                }
                else
                {
                    Console.Write("{0} ", matrix[row, column]);
                }                
            }
            Console.WriteLine();
        }
    }

    static void FillMatrixA(int[,] matrix)
    {
        for (int row = 0, counter = 1; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[column, row] = counter;
                counter++;
            }            
        }
    }

    static void FillMatrixB(int[,] matrix)
    {
        for (int row = 0, counter = 1; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[column, row] = counter;
                counter++;
            }
            if (row < matrix.GetLength(0) - 1)
            {
                row++;
                for (int column = matrix.GetLength(1) - 1; column >= 0; column--)
                {
                    matrix[column, row] = counter;
                    counter++;
                }
            }  
        }
    }
    
    static void FillMatrixC(int[,] matrix)
    {
        int index = 1;
        int size = matrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int yPos = 0, row = size - i - 1; row < size; row++, yPos++)
            {
                matrix[row, yPos] = index;
                index++;
            }     
        }
        for (int i = 0; i < size - 1; i++)
        {
            for (int xPos = 0, column = i + 1; column < size; column++, xPos++)
            {
                matrix[xPos, column] = index;
                index++;
            }
        }     
    }

    static void FillMatrixD(int[,] matrix)
    {
        int counter = 1;
        int indexer = 0;
        int numberN = matrix.GetLength(0);
        while (counter <= (numberN * numberN))
        {
            for (int positiveX = indexer; positiveX < numberN - indexer; positiveX++)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[positiveX, indexer] = counter;
                    counter++;
                }
            }
            for (int negativeY = indexer + 1; negativeY < numberN - indexer; negativeY++)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[numberN - indexer - 1, negativeY] = counter;
                    counter++;
                }
            }
            for (int negativeX = numberN - indexer - 2; negativeX >= indexer; negativeX--)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[negativeX, numberN - indexer - 1] = counter;
                    counter++;
                }
            }
            for (int positiveY = numberN - indexer - 2; positiveY > indexer; positiveY--)
            {
                if (counter <= (numberN * numberN))
                {
                    matrix[indexer, positiveY] = counter;
                    counter++;
                }
            }
            indexer++;
        }
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        switch (symbol)
        {
            case 'a':
                FillMatrixA(matrix);
                break;
            case 'b':
                FillMatrixB(matrix);
                break;
            case 'c':
                FillMatrixC(matrix);
                break;
            case 'd':
                FillMatrixD(matrix);
                break;
            default:
                break;
        }
        PrintMatrix(matrix);
    }
}
