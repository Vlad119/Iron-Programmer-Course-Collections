using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
        for (int i = 0; i < n; i++)
        {
            string[] split = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.None);
            char c = char.Parse(split[0]);
            int count = int.Parse(split[1]);
            letterFrequency.Add(c, count);
        }
        Dictionary<char, int> symbolFrequency = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (symbolFrequency.ContainsKey(c))
            {
                symbolFrequency[c]++;
            }
            else
            {
                symbolFrequency[c] = 1;
            }
        }
        List<KeyValuePair<char, int>> symbolsList = new List<KeyValuePair<char, int>>(symbolFrequency);
        List<KeyValuePair<char, int>> lettersList = new List<KeyValuePair<char, int>>(letterFrequency);
        Dictionary<char, char> mapping = new Dictionary<char, char>();
        for (int i = 0; i < symbolsList.Count; i++)
        {
            mapping[symbolsList[i].Key] = lettersList[i].Key;
        }
        char[] decrypted = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            decrypted[i] = mapping[s[i]];
        }
        Console.WriteLine(new string(decrypted));
    }
}