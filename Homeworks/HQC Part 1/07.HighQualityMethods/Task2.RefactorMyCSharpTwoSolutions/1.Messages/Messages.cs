using System;
using System.Text;
using System.Numerics;

class Messages
{
    static void Main()
    {
        var firstNumber = Console.ReadLine();
        var operation = Console.ReadLine();
        var secondNumber = Console.ReadLine();
        var fNumber = new StringBuilder();
        var sNumber = new StringBuilder();
        var alphabet = new[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
        for (int i = 0; i < firstNumber.Length; i += 3)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (alphabet[j] == firstNumber.Substring(i, 3))
                {
                    fNumber.Append(j);
                }
                if (secondNumber.Length > i)
                {
                    if (alphabet[j] == secondNumber.Substring(i, 3))
                    {
                        sNumber.Append(j);
                    }
                }
            }
        }
        BigInteger first = BigInteger.Parse(fNumber.ToString());
        BigInteger second = BigInteger.Parse(sNumber.ToString());
        BigInteger result = 0;
        switch (operation)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            default:
                break;
        }
        var output = new StringBuilder();
        do
        {
            output.Append(alphabet[(int)(result % 10)], 0, 3);
            result /= 10;
        }
        while (result > 0);
        var outputAsString = output.ToString();
        for (int i = output.Length - 3; i >= 0; i -= 3)
        {
            Console.Write(outputAsString.Substring(i, 3));
        }
        Console.WriteLine();
    }
}