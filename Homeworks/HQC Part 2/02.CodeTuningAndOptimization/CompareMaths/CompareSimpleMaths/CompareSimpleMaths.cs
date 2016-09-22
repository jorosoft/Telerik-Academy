namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class CompareSimpleMaths
    {
        private const int RepeatingTimes = 30000000;

        public static void PrintMeasurementTimeOnConsole(Action operation)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int iterations = 0; iterations < RepeatingTimes; iterations++)
            {
                operation();
            }
                        
            sw.Stop();
            Console.WriteLine("=======================================");
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("=======================================");
            Console.WriteLine();
        }

        internal static void Main()
        {
            Console.WriteLine("***** INTEGER ADDITION *****");
            int intValue = 123;
            PrintMeasurementTimeOnConsole(() => 
            {
                intValue += 5;
            });
            Console.WriteLine("***** LONG ADDITION *****");
            long longValue = int.MaxValue;
            PrintMeasurementTimeOnConsole(() => 
            {
                longValue += 33;
            });
            Console.WriteLine("***** FLOAT ADDITION *****");
            float floatValue = 1.23F;
            PrintMeasurementTimeOnConsole(() => 
            {
                floatValue += 0.3F;
            });
            Console.WriteLine("***** DOUBLE ADDITION *****");
            double doubleValue = 123456789.12;
            PrintMeasurementTimeOnConsole(() => 
            {
                doubleValue += 1.23;
            });
            Console.WriteLine("***** DECIMAL ADDITION *****");
            decimal decimalValue = 1.0000000015M;
            PrintMeasurementTimeOnConsole(() => 
            {
                decimalValue += 0.0000045M;
            });

            Console.WriteLine("***** INTEGER SUBSTRACTION *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                intValue -= 5;
            });
            Console.WriteLine("***** LONG SUBSTRACTION *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                longValue -= 33;
            });
            Console.WriteLine("***** FLOAT SUBSTRACTION *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                floatValue -= 0.3F;
            });
            Console.WriteLine("***** DOUBLE SUBSTRACTION *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                doubleValue -= 1.23;
            });
            Console.WriteLine("***** DECIMAL SUBSTRACTION *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                decimalValue -= 0.0000045M;
            });

            Console.WriteLine("***** INTEGER INCREMENT *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                intValue++;
            });
            Console.WriteLine("***** LONG INCREMENT *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                longValue++;
            });
            Console.WriteLine("***** FLOAT INCREMENT *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                floatValue++;
            });
            Console.WriteLine("***** DOUBLE INCREMENT *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                doubleValue++;
            });
            Console.WriteLine("***** DECIMAL INCREMENT *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                decimalValue++;
            });

            Console.WriteLine("***** INTEGER MULTIPLY *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                intValue *= 1;
            });
            Console.WriteLine("***** LONG MULTIPLY *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                longValue *= 1;
            });
            Console.WriteLine("***** FLOAT MULTIPLY *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                floatValue *= 1;
            });
            Console.WriteLine("***** DOUBLE MULTIPLY *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                doubleValue *= 1;
            });
            Console.WriteLine("***** DECIMAL MULTIPLY *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                decimalValue *= 1;
            });

            Console.WriteLine("***** INTEGER DIVIDE *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                intValue /= 1;
            });
            Console.WriteLine("***** LONG DIVIDE *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                longValue /= 1;
            });
            Console.WriteLine("***** FLOAT DIVIDE *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                floatValue /= 1;
            });
            Console.WriteLine("***** DOUBLE DIVIDE *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                doubleValue /= 1;
            });
            Console.WriteLine("***** DECIMAL DIVIDE *****");
            PrintMeasurementTimeOnConsole(() =>
            {
                decimalValue /= 1;
            });
        }
    }
}
