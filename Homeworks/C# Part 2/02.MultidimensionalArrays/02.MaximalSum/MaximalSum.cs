using System;

class MaximalSum
{
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
        int patternWidth = 3;
        int patternHeight = 3;
        int maxSum = int.MinValue;
        for (int row = 0; row <= matrix.GetLength(0) - patternWidth; row++)
        {
            for (int column = 0; column <= matrix.GetLength(1) - patternHeight; column++)
            {
                int tempSum = 0;
                for (int patternRow = row; patternRow < row + patternWidth; patternRow++)
                {
                    for (int patternCol = column; patternCol < column + patternHeight; patternCol++)
                    {
                        tempSum += matrix[patternRow, patternCol];
                    }
                }
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}
