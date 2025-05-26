using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //программа определяет, являются ли 2 строки анаграммами
        string word1 = Console.ReadLine().ToLower();
        string word2 = Console.ReadLine().ToLower();
        string w1 = string.Empty;
        string w2 = string.Empty;
        foreach (var c in word1)
        {
            if (char.IsLetter(c))
            {
                w1 += c;
            }
        }
        foreach (var c in word2)
        {
            if (char.IsLetter(c))
            {
                w2 += c;
            }
        }
        Console.WriteLine(AreAnagrams(w1, w2) ? "YES" : "NO");
    }

    static bool AreAnagrams(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency.Add(c, 1);
            }
        }
        foreach (char c in s2)
        {
            if (!frequency.ContainsKey(c)) return false;
            frequency[c]--;
        }
        foreach (int count in frequency.Values)
        {
            if (count != 0) return false;
        }
        return true;
    }
}