namespace _03.RangeExceptions
{
    using System;

    internal class RangeExceptions
    {
        internal static void Main()
        {
            var startInt = 1;
            var endInt = 100;
            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);
            
            //// Change values of this variables to test custom exception...
            var testNumber = 101;
            var testDate = new DateTime(2012, 12, 12);

            try
            {
                var data = CheckIfDataIsInRange(testNumber, startInt, endInt);
                if (data)
                {
                    Console.WriteLine("Given number is in range!");
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Exception handled : {0}", ex.Message);
            }

            try
            {
                var otherData = CheckIfDataIsInRange(testDate, startDate, endDate);
                if (otherData)
                {
                    Console.WriteLine("Given date is in range!");
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Exception handled : {0}", ex.Message);
            }
        }

        internal static bool CheckIfDataIsInRange<T>(T checkedData, T start, T end) where T : IComparable<T>
        {
            if (checkedData.CompareTo(start) < 0 || checkedData.CompareTo(end) > 0)
            {
                throw new InvalidRangeException<T>("The given data is not in range!");
            }

            return true;
        } 
    }
}
