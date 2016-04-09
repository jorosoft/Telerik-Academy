using System;

class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSearchedNumber;
        if (number % 7 == 0 && number % 5 == 0)
        {
            isSearchedNumber = true;
        }
        else
        {
            isSearchedNumber = false;
        }
        if (isSearchedNumber)
        {
            Console.WriteLine("true {0}", number);
        }
        else
        {
            Console.WriteLine("false {0}", number);
        }
    }
}