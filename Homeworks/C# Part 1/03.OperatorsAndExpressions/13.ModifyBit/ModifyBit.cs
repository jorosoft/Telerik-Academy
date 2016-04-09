using System;

class ModifyBit
{
    static void Main()
    {
        ulong numberN = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        ulong newBitValue = ulong.Parse(Console.ReadLine());
        ulong mask;
        if (newBitValue == 0)
        {
            mask = ~((ulong)1 << position);
            numberN = numberN & mask;
        }
        else
        {
            mask = (ulong)1 << position;
            numberN = numberN | mask;
        }
        Console.WriteLine(numberN);
    }
}