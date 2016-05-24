using System;

class Feathers
{
    static void Main()
    {
        int numberB = int.Parse(Console.ReadLine());
        int numberF = int.Parse(Console.ReadLine());
        double average = 0;
        if (numberB != 0)
        {
            average = (double)numberF / numberB;
        }
        if (numberB % 2 == 0)
        {
            Console.WriteLine("{0:F4}", average * 123123123123);

        }
        else
        {
            Console.WriteLine("{0:F4}", average / 317.00);
        }
    }
}
