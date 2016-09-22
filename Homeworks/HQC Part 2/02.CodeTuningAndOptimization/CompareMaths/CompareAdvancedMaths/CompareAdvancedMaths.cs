namespace CompareAdvancedMaths
{
    using System;
    using CompareSimpleMaths;

    internal class CompareAdvancedMaths
    {
        internal static void Main()
        {
            double result;
            Console.WriteLine("***** TEST SQRT ON FLOAT *****");
            float floatValue = 1.23F;
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() => 
            {
                result = Math.Sqrt(floatValue);
            });
            Console.WriteLine("***** TEST SQRT ON DOUBLE *****");
            double doubleValue = 123456789.12;
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() => 
            {
                result = Math.Sqrt(doubleValue);
            });
            Console.WriteLine("***** TEST SQRT ON DECIMAL *****");
            decimal decimalValue = 1.000000000023M;
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Sqrt((double)decimalValue);
            });

            Console.WriteLine("***** TEST LN ON FLOAT *****");
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Log(floatValue);
            });
            Console.WriteLine("***** TEST LN ON DOUBLE *****");
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Log(doubleValue);
            });
            Console.WriteLine("***** TEST LN ON DECIMAL *****");
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Log((double)decimalValue);
            });

            Console.WriteLine("***** TEST SINUS ON FLOAT *****");
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Sin(floatValue);
            });
            Console.WriteLine("***** TEST SINUS ON DOUBLE *****");
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Sin(doubleValue);
            });
            Console.WriteLine("***** TEST SINUS ON DECIMAL *****");
            CompareSimpleMaths.PrintMeasurementTimeOnConsole(() =>
            {
                result = Math.Sin((double)decimalValue);
            });
        }
    }
}
