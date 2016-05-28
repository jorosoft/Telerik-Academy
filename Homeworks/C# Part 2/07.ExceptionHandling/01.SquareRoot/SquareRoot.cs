using System;

class NegativeNumberException : ArgumentException
{

}

class SquareRoot
{
    static void PrintSquareRoot(double number)
    {
        if (number >= 0)
        {
            Console.WriteLine("{0:F3}", Math.Sqrt(number));
        }
        else
        {
            throw new NegativeNumberException();
        }
    }

    static void Main()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());
            PrintSquareRoot(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (NegativeNumberException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
