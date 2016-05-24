using System;

class NumberOfPages
{
    static void Main()
    {
        int numberD = int.Parse(Console.ReadLine());
        int numberN = 0;
        while (numberD > 0)
        {
            numberN++;
            numberD -= numberN.ToString().Length;            
        }
        Console.WriteLine(numberN);
    }
}