using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long result = 0;
        long symbol = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i].ToString())
            {
                case "A":
                    symbol = 10;
                    break;
                case "B":
                    symbol = 11;
                    break;
                case "C":
                    symbol = 12;
                    break;
                case "D":
                    symbol = 13;
                    break;
                case "E":
                    symbol = 14;
                    break;
                case "F":
                    symbol = 15;
                    break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    symbol = long.Parse(input[i].ToString());
                    break;
                default:
                    break;
            }
            result +=  symbol * (long)Math.Pow(16, input.Length - i - 1);
        }
        Console.WriteLine(result);
    }
}