namespace StudentsAndCourses
{
    using System;

    public static class Validator
    {
        private const uint MinIdValue = 10000;
        private const uint MaxIdValue = 99999;
        private const byte MaxStudentsInCourse = 30;

        public static void ValidateStringIsNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void ValidateIdInRange(int value, string message)
        {
            if (value < MinIdValue || value > MaxIdValue)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void ValidateStudentsCountInCourse(byte value, string message)
        {
            if (value >= MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
