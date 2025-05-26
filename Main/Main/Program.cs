using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] split = Console.ReadLine().ToLower().Split();
        Dictionary<string, int> words = new Dictionary<string, int>();
        string s = string.Empty;
        foreach (var str in split)
        {
            if (words.ContainsKey(str))
            {
                words[str]++;
            }
            else
            {
                words.Add(str, 1);
            }
            s += words[str] + " ";
        }
        Console.Write($"{s} ");
    }
}