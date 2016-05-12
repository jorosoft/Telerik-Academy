using System;

class SayHello
{
    static void PrintName()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        PrintName();
    }
}
