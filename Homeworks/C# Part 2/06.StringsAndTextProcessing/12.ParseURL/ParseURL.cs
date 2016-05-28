using System;

class ParseURL
{
    static void Main()
    {
        string input = Console.ReadLine();
        int firstSeparatorIndex = input.IndexOf("://");
        string protocol = input.Remove(firstSeparatorIndex);
        input = input.Remove(0, firstSeparatorIndex + 3);
        int secondSeparatorIndex = input.IndexOf("/");
        string server = input.Remove(secondSeparatorIndex);
        string resource = input.Remove(0, secondSeparatorIndex);
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[server] = {0}", server);
        Console.WriteLine("[resource] = {0}", resource);
    }
}
