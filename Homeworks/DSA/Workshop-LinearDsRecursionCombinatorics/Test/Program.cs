namespace Passwords
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        static int length;
        static List<string> results = new List<string>();
        static string directions;
        static int k;

        static void Main()
        {
            length = int.Parse(Console.ReadLine());
            directions = Console.ReadLine();
            k = int.Parse(Console.ReadLine());
            int[] password = new int[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = -1;
            }

            for (int i = 0; i < 10; i++)
            {
                password[0] = i;
                int digit = i;
                if (i == 0)
                {
                    digit = 10;
                }

                GetPass(digit, 0, password, 1);
            }

            Console.WriteLine(results[k - 1]);
        }

        private static int GetDirectionByIndex(int dirIndex)
        {
            char dir = directions[dirIndex];
            if (dir == '=')
            {
                return 0;
            }
            else if (dir == '>')
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        static void GetPass(int currentDigit, int dirIndex, int[] combination, int passIndex)
        {
            if (results.Count == k)
            {
                return;
            }

            if (passIndex == length)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < length; i++)
                {
                    sb.Append(combination[i]);
                }
                results.Add(sb.ToString());

                return;
            }

            if (dirIndex >= directions.Length)
            {
                return;
            }

            int dir = GetDirectionByIndex(dirIndex);
            if (currentDigit + dir < 1 || currentDigit + dir > 10)
            {
                return;
            }

            if (dir == 0)
            {
                var next = currentDigit;
                if (currentDigit == 10)
                {
                    next = 0;
                }

                combination[passIndex] = next;
                GetPass(currentDigit, dirIndex + 1, combination, passIndex + 1);
                combination[passIndex] = -1;
            }
            else if (dir == 1)
            {
                combination[passIndex] = 0;
                GetPass(10, dirIndex + 1, combination, passIndex + 1);
                combination[passIndex] = -1;

                for (int i = currentDigit + 1; i < 10; i++)
                {
                    var next = i;
                    combination[passIndex] = next;
                    GetPass(i, dirIndex + 1, combination, passIndex + 1);
                    combination[passIndex] = -1;
                }
            }
            else
            {
                for (int i = 1; i < currentDigit; i++)
                {
                    var next = i;
                    combination[passIndex] = next;
                    GetPass(i, dirIndex + 1, combination, passIndex + 1);
                    combination[passIndex] = -1;
                }
            }
        }
    }
}