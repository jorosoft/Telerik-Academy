using System;

namespace Passwords
{
    internal class Startup
    {
        internal static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            //int k = int.Parse(Console.ReadLine());
            var pass = new int[n];
            //GetPassword(n, 0, 0, order, pass);
            GetPass(n, 0, order, pass, 1);

        }       

        public static void GetPass(int length, int index, string order, int[] pass, int k)
        {
            int[] digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int startDigit = 0;
            if (index == length)
            {
                PrintPass(pass, k);
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (index > 0)
                    {
                        if (order[index - 1] == '=')
                        {
                            pass[index] = pass[index - 1];
                            GetPass(length, index + 1, order, pass, k);
                            break;
                        }
                        if (order[index - 1] == '>')
                        {
                            startDigit = pass[index - 1] + 1;
                            for (int j = startDigit; j <= 10; j++)
                            {
                                pass[index] = digits[j - 1];                                
                                GetPass(length, index + 1, order, pass, k);                                
                            }
                            
                            break;
                        }
                        if (order[index - 1] == '<')
                        {

                        }
                    }
                    else
                    {
                        pass[index] = digits[i];
                        GetPass(length, index + 1, order, pass, k);
                    }
                }
            }
        }



        private static void PrintPass(int[] pass, int k)
        {
            foreach (int symbol in pass)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}
