using System;

class LargestAreaInMatrix
{
    static int CountAreaForElement(int[,] matrix, int element, int row, int col, bool[,] visitedCells, int maxRows, int maxCols)
    {
        int count = 0;
        bool insideMatrix = false;
        if ((row >= 0 && row < maxRows) && (col >= 0 && col < maxCols))
        {
            insideMatrix = true;
        }
        if (insideMatrix)
        {
            if (visitedCells[row, col] == true)
            {
                insideMatrix = false;
            }
        }
        if (!insideMatrix)
        {
            return count;
        }
        else
        {
            if (matrix[row, col] == element)
            {
                count++;
                visitedCells[row, col] = true;
                count += CountAreaForElement(matrix, element, row, col + 1, visitedCells, maxRows, maxCols);
                count += CountAreaForElement(matrix, element, row, col - 1, visitedCells, maxRows, maxCols);
                count += CountAreaForElement(matrix, element, row - 1, col, visitedCells, maxRows, maxCols);
                count += CountAreaForElement(matrix, element, row + 1, col, visitedCells, maxRows, maxCols);
            }
        }
        return count;
    }

    static void Main()
    {
        string[] dimm = Console.ReadLine().Split(' ');
        int matrixRows = int.Parse(dimm[0]);
        int matrixColumns = int.Parse(dimm[1]);
        int[,] matrix = new int[matrixRows, matrixColumns];
        for (int row = 0; row < matrixRows; row++)
        {
            string[] rowString = Console.ReadLine().Split(' ');
            for (int column = 0; column < matrixColumns; column++)
            {
                matrix[row, column] = int.Parse(rowString[column]);
            }
        }
        int maxCount = 0;
        int tempCount = 0;
        bool[,] visitedCells = new bool[matrixRows, matrixColumns];
        for (int row = 0; row < matrixRows; row++)
        {
            for (int col = 0; col < matrixColumns; col++)
            {
                tempCount = CountAreaForElement(matrix, matrix[row, col], row, col, visitedCells, matrixRows, matrixColumns);
                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                }
            }
        }
        Console.WriteLine(maxCount);
    }
}