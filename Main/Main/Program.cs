using System;
using System.Collections.Generic;

class Program
{
    static void Main()

    {
        string[] identifiers = Console.ReadLine().Split();
        Dictionary<string, int> counts = new Dictionary<string, int>();
        List<string> result = new List<string>();
        foreach (string str in identifiers)
        {
            if (!counts.ContainsKey(str))
            {
                result.Add(str);
                counts[str] = 1;
            }
            else
            {
                int count = counts[str];
                result.Add($"{str}_{count}");
                counts[str]++;
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}