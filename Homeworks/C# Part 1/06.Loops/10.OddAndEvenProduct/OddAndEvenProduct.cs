using System;

class OddAndEvenProduct
{
    static void Main()
    {
        byte numbersCount = byte.Parse(Console.ReadLine());
        string numbers = Console.ReadLine();
        string[] singleNumber = numbers.Split(' ');
        long productOdd = 1;
        long productEven = 1;
        for (byte i = 0; i < numbersCount; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= Convert.ToInt32(singleNumber[i]);
            }
            else
            {
                productEven *= Convert.ToInt32(singleNumber[i]);
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes {0}", productEven);
        }
        else
        {
            Console.WriteLine("no {0} {1}", productOdd, productEven);
        }
    }
}
