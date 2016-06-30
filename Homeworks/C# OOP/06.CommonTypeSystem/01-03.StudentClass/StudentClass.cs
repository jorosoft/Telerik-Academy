namespace _01_03.StudentClass
{
    using System;

    internal class StudentClass
    {
        internal static void Main()
        {
            var studentOne = new Student("Pesho", "Todorov", "Petrov", 1234, "Plovdiv, ul. \"Sveta Marina\" 56", 
                "0887664345", "ala@bala.bg", "C# Fundamentals", Specialty.CST, University.TU, Faculty.FEA);
            var studentTwo = new Student("Sashka", "Kirilova", "Asanova", 7878, "Burgas, ul. \"Bacho Kiro\" 16",
                "0898754211", "sashka@lashka.org", "WEB Design", Specialty.PD, University.SU, Faculty.FMI);
            var studentThree = new Student("Pesho", "Todorov", "Petrov", 1234, "Plovdiv, ul. \"Sveta Marina\" 56",
                "0887664345", "ala@bala.bg", "C# Fundamentals", Specialty.CST, University.TU, Faculty.FEA);
            Console.WriteLine("*************** TEST EQUALS ***************");
            Console.WriteLine("Is Student 1 Equal to Student 2 ? : {0}", studentOne.Equals(studentTwo));
            Console.WriteLine("Is Student 1 Equal to Student 3 ? : {0}", studentOne.Equals(studentThree));
            Console.WriteLine();
            Console.WriteLine("************** TEST TOSTRING **************");
            Console.WriteLine(studentOne.ToString());
            Console.WriteLine("************ TEST GETHASHCODE *************");
            Console.WriteLine("Student 1 Hash Code: {0}", studentOne.GetHashCode());
            Console.WriteLine("Student 2 Hash Code: {0}", studentTwo.GetHashCode());
            Console.WriteLine("Student 3 Hash Code: {0}", studentThree.GetHashCode());
            Console.WriteLine("Student 1 Hash Code: {0}", studentOne.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("************ TEST OPERATOR == *************");
            Console.WriteLine("Student 1 == Student 2 ? : {0}", studentOne == studentTwo);
            Console.WriteLine("Student 1 == Student 3 ? : {0}", studentOne == studentThree);
            Console.WriteLine();
            Console.WriteLine("************ TEST OPERATOR != *************");
            Console.WriteLine("Student 1 != Student 2 ? : {0}", studentOne != studentTwo);
            Console.WriteLine("Student 1 != Student 3 ? : {0}", studentOne != studentThree);
            Console.WriteLine();
            Console.WriteLine("************** TEST CLONING ***************");
            var studentFour = studentTwo.Clone();
            Console.WriteLine("++++++++++ New Copy Of Student 2 ++++++++++");
            Console.Write(studentFour.ToString());
            Console.WriteLine("Hash Code Of New Student: {0}", studentFour.GetHashCode());
            Console.WriteLine();
            Console.WriteLine("************* TEST COMPARING **************");
            Console.WriteLine("Student 1 compare to Student 2 : {0}", studentOne.CompareTo(studentTwo));
            Console.WriteLine();
        }
    }
}
