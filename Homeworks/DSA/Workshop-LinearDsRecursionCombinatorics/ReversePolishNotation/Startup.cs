using System;
using System.Collections.Generic;

namespace ReversePolishNotation
{
    internal class Startup
    {
        internal static void Main()
        {
            string input = Console.ReadLine();
            if (input == null)
            {
                return;
            }

            int result = ReversePolishNotation(input);
            Console.WriteLine(result);
        }

        public static int ReversePolishNotation(string expression)
        {
            var expressionParts = expression.Trim().Split(' ');
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expressionParts.Length; i++)
            {
                int number;
                if (int.TryParse(expressionParts[i], out number))
                {
                    stack.Push(number);
                }
                else
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException();
                    }

                    var operandOne = stack.Pop();
                    var operandTwo = stack.Pop();
                    var operationResult = Evaluate(operandOne, operandTwo, expressionParts[i]);
                    if (operationResult != null)
                    {
                        stack.Push((int)operationResult);
                    }
                }
            }

            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException();
            }            
        } 

        private static int? Evaluate(int operandOne, int operandTwo, string oper)
        {
            int? result = null;
            switch (oper)
            {
                case "+": result = operandTwo + operandOne;
                    break;
                case "-": result = operandTwo - operandOne;
                    break;
                case "*": result = operandTwo * operandOne;
                    break;
                case "/": result = operandTwo / operandOne;
                    break;
                case "&": result = operandTwo & operandOne;
                    break;
                case "|": result = operandTwo | operandOne;
                    break;
                case "^": result = operandTwo ^ operandOne;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
