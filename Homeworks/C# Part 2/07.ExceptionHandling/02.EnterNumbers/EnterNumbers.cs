using System;
using System.Collections.Generic;

class NotInRangeException : Exception
{

}

class NotInSequenceException : Exception
{

}

class EnterNumbers
{
    static List<int> numbers = new List<int>();

    static void ReadNumber(int start, int end)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < end)
            {
                if (numbers.Count == 0 || number > numbers[numbers.Count - 1])
                {
                    numbers.Add(number);
                }
                else
                {
                    throw new NotInSequenceException();
                }
            }
            else
            {
                throw new NotInRangeException();
            }
        }
        catch (FormatException)
        {
            throw;
        }
        catch (OverflowException)
        {
            throw;
        }
    }

    static void Main()
    {
        int numbersCount = 10;
        int start = 1;
        int end = 100;
        try
        {
            for (int i = 0; i < numbersCount; i++)
            {
                ReadNumber(start, end);
            }
            Console.Write(start);
            foreach (var item in numbers)
            {
                Console.Write(" < " + item);
            }
            Console.WriteLine(" < " + end);
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }
}