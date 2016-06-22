namespace _6.DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    internal class DivisibleBySevenAndThree
    {
        internal static void Main()
        {
            var numbers = new[] { 15, 7, 18, 22, 1, 301, 0, 5, 11, 21 };
            Console.WriteLine("========= ARRAY OF NUMBERS =========");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("====== DIVISIBLE BY 7 AND 3 ======");
            var resultNumbers = numbers
                .Where(num => num % 7 == 0 && num % 3 == 0)
                .ToList();
            foreach (var number in resultNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine("== DIVISIBLE BY 7 AND 3 WITH LINQ ==");
            var resultNumbersLinq =
                (from n in numbers
                where n % 7 == 0 && n % 3 == 0
                select n)
                .ToList();
                
            foreach (var number in resultNumbersLinq)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
