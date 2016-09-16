namespace ConsoleWriter
{
    using System;

    public class ConsoleWriter
    {
        public void Write(bool condition)
        {
            string conditionAsString = condition.ToString();
            Console.WriteLine(conditionAsString);
        }
    }
}
