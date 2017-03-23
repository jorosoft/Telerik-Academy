namespace Methods
{
    using System;
    using Common;
    using Enumerations;
    using Models;

    public class Startup
    {
        internal static void Main()
        {
            Console.WriteLine(Calculator.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Converter.DigitToWord(5));

            Console.WriteLine(Calculator.FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(Converter.NumberToString(1.3, "f"));
            Console.WriteLine(Converter.NumberToString(0.75, "%"));
            Console.WriteLine(Converter.NumberToString(2.30, "r"));

            DirectionType direction;
            Console.WriteLine(Calculator.CalcDistance(3, -1, 3, 2.5, out direction));
            Console.WriteLine("Horizontal? " + (direction == DirectionType.Horizontal));
            Console.WriteLine("Vertical? " + (direction == DirectionType.Vertical));

            Student peter = new Student("Peter", "Ivanov");
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova");
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }
    }
}
