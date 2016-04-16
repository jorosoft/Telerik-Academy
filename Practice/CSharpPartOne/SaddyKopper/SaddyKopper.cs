using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string number = Console.ReadLine();
        BigInteger product = 1;
        int transformations = 0;
        while (number.Length > 0)
        {
            int sum = 0;
            number = number.Remove(number.Length - 1, 1);
            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += Convert.ToByte(number[i].ToString());
                }
            }
            if (number.Length > 0)
            {
                product *= sum;
            }
            else
            {
                transformations++;
                if (product > 9 && transformations < 10)
                {
                    number = product.ToString();
                    product = 1;
                }
                else break;
            }
        }
        if (transformations < 10)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(product);
        }
        else
        {
            Console.WriteLine(product);
        }
    }
}