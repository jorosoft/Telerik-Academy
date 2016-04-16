using System;

class Printing
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double totalRealms = (double)(n * s) / 500;
        Console.WriteLine("{0:F2}", totalRealms * p);
    }
}