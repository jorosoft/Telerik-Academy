using System;

class SequenceInMatrix
{
    static int CheckRows(int[,] matrix)
    {
        int count = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int tempCount = 1;
            for (int column = 0; column < matrix.GetLength(1) - 1; column++)
            {
                if (matrix[row, column] == matrix[row, column + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }
                if (count < tempCount)
                {
                    count = tempCount;
                }
            }
        }
        return count;
    }

    static int CheckColumns(int[,] matrix)
    {
        int count = 0;
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            int tempCount = 1;
            for (int column = 0; column < matrix.GetLength(0) - 1; column++)
            {
                if (matrix[column, row] == matrix[column + 1, row])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }
                if (count < tempCount)
                {
                    count = tempCount;
                }
            }
        }
        return count;
    }

    static int CheckRightDiagonals(int[,] matrix)
    {
        int count = 1;
        for (int startRow = 0; startRow < matrix.GetLength(0); startRow++)
        {
            for (int startColumn = 0; startColumn < matrix.GetLength(1); startColumn++)
            {
                int tempCount = 1;
                for (int comparedRow = startRow; comparedRow < matrix.GetLength(0) - 1; comparedRow++)
                {
                    for (int comparedCol = startColumn + comparedRow; comparedCol < matrix.GetLength(1) - 1; comparedCol++)
                    {
                        if (matrix[comparedRow, comparedCol] == matrix[comparedRow + 1, comparedCol + 1])
                        {
                            tempCount++;
                        }
                        else
                        {
                            tempCount = 1;
                        }
                        if (count < tempCount)
                        {
                            count = tempCount;
                        }
                        break;
                    }
                }
            }
        }
        return count;
    }

    static int CheckLeftDiagonals(int[,] matrix)
    {
        int count = 1;
        for (int startRow = 0; startRow < matrix.GetLength(0); startRow++)
        {
            for (int startColumn = matrix.GetLength(1) - 1; startColumn >= 0; startColumn--)
            {
                int tempCount = 1;
                for (int comparedRow = startRow; comparedRow < matrix.GetLength(0) - 1; comparedRow++)
                {
                    for (int comparedCol = startColumn - comparedRow; comparedCol > 0; comparedCol--)
                    {
                        if (matrix[comparedRow, comparedCol] == matrix[comparedRow + 1, comparedCol - 1])
                        {
                            tempCount++;
                        }
                        else
                        {
                            tempCount = 1;
                        }
                        if (count < tempCount)
                        {
                            count = tempCount;
                        }
                        break;
                    }
                }
            }
        }
        return count;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        string[] dimm = input.Split(' ');
        int numberN = int.Parse(dimm[0]);
        int numberM = int.Parse(dimm[1]);
        int[,] matrix = new int[numberN, numberM];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] rowString = Console.ReadLine().Split(' ');
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = int.Parse(rowString[column]);
            }
        }
        int sequenceLength = CheckRows(matrix);
        if (CheckColumns(matrix) > sequenceLength)
        {
            sequenceLength = CheckColumns(matrix);
        }
        if (CheckRightDiagonals(matrix) > sequenceLength)
        {
            sequenceLength = CheckRightDiagonals(matrix);
        }
        if (CheckLeftDiagonals(matrix) > sequenceLength)
        {
            sequenceLength = CheckLeftDiagonals(matrix);
        }
        Console.WriteLine(sequenceLength);
    }
}
