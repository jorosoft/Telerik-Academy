using System;

class NTthBit
{
    static void Main()
    {
        long numberP = long.Parse(Console.ReadLine());
        byte numberN = byte.Parse(Console.ReadLine());
        long mask = 1 << numberN;
        long result;
        result = (numberP & mask) >> numberN;
        Console.WriteLine(result);
    }}
