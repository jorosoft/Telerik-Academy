using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime bDate = DateTime.ParseExact(input, "MM.dd.yyyy", null);
        int years = DateTime.Now.Year - bDate.Year;
        if ((DateTime.Now.Year > bDate.Year && DateTime.Now.Month < bDate.Month) || 
            (DateTime.Now.Year > bDate.Year && DateTime.Now.Month == bDate.Month && DateTime.Now.Day < bDate.Day))
        {
            years--;
        }
        Console.WriteLine(years);
        Console.WriteLine(years+10);        
    }
}

