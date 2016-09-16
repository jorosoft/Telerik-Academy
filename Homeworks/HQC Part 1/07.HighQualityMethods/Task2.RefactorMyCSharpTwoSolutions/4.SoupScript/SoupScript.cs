using System;
using System.Collections.Generic;

class SoupScript
{
    static void TrimStrings(string[] input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = input[i].Trim();
        }
    }

    static string RepairWhiteSpaces(string input)
    {
        var splitByOpenBracket = input.Split('(');
        TrimStrings(splitByOpenBracket);
        string resultOne = string.Join("(", splitByOpenBracket);
        var splitByCloseBracket = resultOne.Split(')');
        TrimStrings(splitByCloseBracket);
        string resultTwo = string.Join(")", splitByCloseBracket);
        var splitByBullet = resultTwo.Split('.');
        TrimStrings(splitByBullet);
        string resultThree = string.Join(".", splitByBullet);
        var splitBySign = resultThree.Split('!');
        TrimStrings(splitBySign);
        string resultFour = string.Join("!", splitBySign);
        var splitByOtherSign = resultFour.Split(';');
        TrimStrings(splitByOtherSign);
        string result = string.Join(";", splitByOtherSign);
        return result;
    }

    static void Normalize(List<string> input)
    {
        for (int i = 0; i < input.Count; i++)
        {
            var indexEqual = input[i].IndexOf("=");
            var indexFormBracket = input[i].IndexOf("{");
            var indexPlus = input[i].IndexOf("+");
            var indexComma = input[i].IndexOf(",");
            if (indexEqual > 0)
            {
                if (input[i][indexEqual - 1] != ' ')
                {
                    input[i] = input[i].Replace("=", " =");
                }
                if (input[i][indexEqual + 1] != ' ')
                {
                    input[i] = input[i].Replace("=", "= ");
                }
            }
            if (indexPlus > 0)
            {
                if (input[i][indexPlus - 1] != ' ')
                {
                    input[i] = input[i].Replace("+", " +");
                }
                
            }
            if (indexComma > 0)
            {
                if (input[i][indexComma - 1] != ' ')
                {
                    input[i] = input[i].Replace(" ,", ",");
                }
                if (input[i][indexComma + 1] != ' ')
                {
                    input[i] = input[i].Replace(",", ", ");
                }
            }
            if (indexFormBracket >= 0)
            {
                input[i] = input[i].Replace("{", " {");
            }
        }
    }

    static void Main()
    {
        var linesCount = int.Parse(Console.ReadLine());
        var code = new List<string>();
        var fixedCode = new List<string>();
        for (int i = 0; i < linesCount; i++)
        {
            code.Add(Console.ReadLine());
        }
        int openBrackets = 0;
        for (int i = 0; i < linesCount; i++)
        {
            var addedSpaces = new string(' ', openBrackets * 4);
            var commentIndex = code[i].IndexOf("//");
            if (commentIndex > 0)
            {
                fixedCode.Add(addedSpaces + code[i].Substring(commentIndex).Trim());
                code[i] = code[i].Remove(commentIndex);
            }
            if (commentIndex == 0)
            {
                fixedCode.Add(addedSpaces + code[i]);
                continue;
            }
            if (code[i].Trim() == string.Empty)
            {
                continue;
            }
            code[i] = RepairWhiteSpaces(code[i]);
            var words = code[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (code[i].IndexOf('}') >= 0)
            {
                openBrackets--;
                addedSpaces = new string(' ', openBrackets * 4);
            }
            if (openBrackets > 0)
            {
                fixedCode.Add(addedSpaces + string.Join(" ", words));
            }
            else
            {
                fixedCode.Add(string.Join(" ", words));
            }
            if (code[i].IndexOf('{') >= 0)
            {
                openBrackets++;
            }
        }
        Normalize(fixedCode);
        foreach (var line in fixedCode)
        {
            Console.WriteLine(line);
        }
    }
}