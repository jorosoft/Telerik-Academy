using System;

class IntDoubleAndString
{
    static void Main()
    {
        string inputType = Console.ReadLine();
        string inputValue = Console.ReadLine();
        switch (inputType)
        {
            case "integer":
                int result = Convert.ToInt32(inputValue);
                Console.WriteLine("{0}", result + 1);
                break;
            case "real":
                double resultTwo = Convert.ToDouble(inputValue);
                Console.WriteLine("{0:F2}", resultTwo + 1);
                break;
            case "text":
                Console.WriteLine("{0}*", inputValue);
                break;
            default:
                break;
        }
    }
}