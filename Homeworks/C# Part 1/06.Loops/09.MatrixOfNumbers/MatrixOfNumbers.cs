using System;

class MatrixOfNumbers
{
    static void Main()
    {
        byte numberN = byte.Parse(Console.ReadLine());
        for (byte column = 1; column <= numberN; column++)
        {
            for (byte row = 0; row < numberN; row++)
            {
                if (row < numberN)
                {
                    Console.Write("{0} ", row + column);
                }
                else
                {
                    Console.Write(row);
                }                
            }
            Console.WriteLine();
        }        
    }
}