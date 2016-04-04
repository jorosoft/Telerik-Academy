using System;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if (Math.Abs(firstNumber-secondNumber) < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
