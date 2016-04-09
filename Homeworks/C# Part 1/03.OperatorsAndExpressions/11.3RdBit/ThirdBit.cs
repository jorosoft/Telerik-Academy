using System;

class ThirdBit
{
    static void Main()
    {
        uint input = uint.Parse(Console.ReadLine());
        uint mask = 1 << 3;
        uint result;
        result = (input & mask) >> 3;
        Console.WriteLine(result);
    }
}
