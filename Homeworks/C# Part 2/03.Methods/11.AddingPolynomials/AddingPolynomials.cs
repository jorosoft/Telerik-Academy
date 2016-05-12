using System;

class AddingPolynomials
{
    static int[] AddPolynomials(int[] arrOne, int[] arrTwo)
    {
        int[] resultArr = new int[arrOne.Length];
        for (int i = 0; i < resultArr.Length; i++)
        {
            resultArr[i] = arrOne[i] + arrTwo[i];
        }

        return resultArr;
    }

    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        string[] inputA = Console.ReadLine().Split(' ');
        string[] inputB = Console.ReadLine().Split(' ');
        int[] polynomialOne = new int[numberN];
        int[] polynomialTwo = new int[numberN];
        for (int i = 0; i < numberN; i++)
        {
            polynomialOne[i] = int.Parse(inputA[i]);
            polynomialTwo[i] = int.Parse(inputB[i]);
        }
        Console.WriteLine(string.Join(" ", AddPolynomials(polynomialOne, polynomialTwo)));
    }
}